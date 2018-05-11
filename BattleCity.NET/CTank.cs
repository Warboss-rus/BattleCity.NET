using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace BattleCity.NET
{
    class CTank
    {
        [DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
        static extern IntPtr LoadLibrary(string dllToLoad);
        [DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);
        [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
        static extern bool FreeLibrary(IntPtr hModule);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)] 
        delegate void SetCoords(int x, int y);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void SetAngle(int angle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void SetTurretAngle(int angle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void SetCollisionStatus(bool isCollided);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void SetLivePercent(int percent);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void SetVisilbeEnemyCount(int count);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void SetEnemyProteries(int enemyID, int x, int y, int angle, int turretAngle, int livePercent);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int GetDirection();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int GetRotateDirection();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int GetRotateSpeed();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int GetTurretRotateDirection();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int GetTurretRotateSpeed();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int GetFireDistance();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate void Update();

        public CTank(string dll, string image, List<CTank> tanks)
        {
            LoadDLL(dll);
            try
            {
                m_base = Image.FromFile(@"Images\Bases\" + image);
                m_turret = Image.FromFile(@"Images\Turrets\" + image);
                m_tank = Image.FromFile(@"Images\Tanks\" + image);
                
            }
            catch
            {
                CConstants.error = 1;
                return;
            }
            m_base = m_base.GetThumbnailImage(CConstants.tankSize, CConstants.tankSize, null, IntPtr.Zero);
            m_turret = m_turret.GetThumbnailImage(CConstants.turretSize, CConstants.turretSize, null, IntPtr.Zero);
            m_tank = m_tank.GetThumbnailImage(50, 50, null, IntPtr.Zero);
            Random rnd = new Random();
            int triescount = 0;
            do
            {
                m_x = rnd.Next(CConstants.formWidth - CConstants.tankSize) + CConstants.tankSize / 2;
                m_y = rnd.Next(CConstants.formHeight - CConstants.tankSize) + CConstants.tankSize / 2;
                triescount++;
            } while (!PlacementIsFree(m_x, m_y, tanks) && triescount < 500);
            m_health = 100;
            m_hits = 0;
            m_baseDirection = rnd.Next(360);
            m_turretDirection = m_baseDirection;
            m_deadPlace = -1;
            m_reload = CConstants.reloadTime;
            m_destroyed = false;
        }
        private void LoadDLL(string dll)
        {
            try
            {
                m_dll = LoadLibrary(dll);
                setcoords = (SetCoords)GetFunction(m_dll, typeof(SetCoords), "SetCoords");
                setangle = (SetAngle)GetFunction(m_dll, typeof(SetAngle), "SetAngle");
                setturrentAngle = (SetTurretAngle)GetFunction(m_dll, typeof(SetTurretAngle), "SetTurretAngle");
                setcollisionstatus = (SetCollisionStatus)GetFunction(m_dll, typeof(SetCollisionStatus), "SetCollisionStatus");
                setlivepercent = (SetLivePercent)GetFunction(m_dll, typeof(SetLivePercent), "SetLivePercent");
                setvisibleenemycount = (SetVisilbeEnemyCount)GetFunction(m_dll, typeof(SetVisilbeEnemyCount), "SetVisilbeEnemyCount");
                setenemyproteries = (SetEnemyProteries)GetFunction(m_dll, typeof(SetEnemyProteries), "SetEnemyProteries");
                update = (Update)GetFunction(m_dll, typeof(Update), "Update");
                getrotatedirection = (GetRotateDirection)GetFunction(m_dll, typeof(GetRotateDirection), "GetRotateDirection");
                getrotatespeed = (GetRotateSpeed)GetFunction(m_dll, typeof(GetRotateSpeed), "GetRotateSpeed");
                getdirection = (GetDirection)GetFunction(m_dll, typeof(GetDirection), "GetDirection");
                getturretrotatedirection = (GetTurretRotateDirection)GetFunction(m_dll, typeof(GetTurretRotateDirection), "GetTurretRotateDirection");
                getturretrotatespeed = (GetTurretRotateSpeed)GetFunction(m_dll, typeof(GetTurretRotateSpeed), "GetTurretRotateSpeed");
                getfiredistance = (GetFireDistance)GetFunction(m_dll, typeof(GetFireDistance), "GetFireDistance");
            }
            catch
            {
                CConstants.error = 2;
                return;
            }
        }
        private System.Delegate GetFunction(IntPtr dll, Type type, string functionName)
        {
            IntPtr ptr = GetProcAddress(dll, functionName);
            return Marshal.GetDelegateForFunctionPointer(ptr, type);
        }
        public void Free() 
        {
            FreeLibrary(m_dll);
        }
        private bool PlacementIsFree(double x, double y, List<CTank> tanks)
        {
            for (int i = 0; i < tanks.Count; i++)
            {
                if (tanks[i].CheckCollision(x, y, 2 * CConstants.tankSize))
                {
                    return false;
                }
            }
            return true;
        }
        private List<CTank> GetEnemies(List<CTank> tanks)
        {
            List<CTank> enemies = new List<CTank>();
            for (int i = 0; i < tanks.Count; i++)
            {
                int x0 = Convert.ToInt32(tanks[i].m_x - m_x); //проекция вектора, соединяющего текущий танк со врагом на ось х
                int y0 = -Convert.ToInt32(tanks[i].m_y - m_y); //проекция вектора, соединяющего текущий танк со врагом на ось у
                double angle = -Math.Atan2(y0, x0) * 180 / Math.PI + 90;//угол этого самого вектора
                while (angle < 360)
                {
                    angle += 360;
                }
                while (m_baseDirection < 360)
                {
                    m_baseDirection += 360;
                }
                if ((angle > (m_baseDirection - 45) && angle < (m_baseDirection + 45))
                    || ((angle % 360) > (m_baseDirection - 45) && (angle % 360) < (m_baseDirection + 45))
                    || (angle > (m_baseDirection % 360 - 45) && angle < (m_baseDirection % 360 + 45)))
                {
                    if (!(tanks[i].m_x == m_x && tanks[i].m_y == m_y) && !tanks[i].IsDead())//это мы сами или труп
                    {
                        enemies.Add(tanks[i]);
                    }
                }
                m_baseDirection %= 360;
            }
            return enemies;
        }
        private void TryToMoveForward(double x, double y, List<CTank> tanks)
        {
            bool ableToMove = true;
            bool ableToMoveX = true;
            bool ableToMoveY = true;
            for(int i = 0; i < tanks.Count; i++)
            {
                if (tanks[i] != this)
                {
                    if (tanks[i].CheckCollision(m_x + x, m_y - y, CConstants.tankSize))
                    {
                        ableToMove = false;
                        if (tanks[i].IsDead())
                        {
                            tanks[i].m_destroyed = true;
                            ableToMove = true;
                        }
                    }
                }
            }
            if (ableToMove)
            {
                m_x += x;
                m_y -= y;
                return;
            }
            for (int i = 0; i < tanks.Count; i++)
            {
                if (tanks[i] != this)
                {
                    if (tanks[i].CheckCollision(m_x + x, m_y, CConstants.tankSize))
                    {
                        ableToMoveX = false;
                    }
                }
            }
            if (ableToMoveX)
            {
                m_x += x;
                return;
            }
            for (int i = 0; i < tanks.Count; i++)
            {
                if (tanks[i] != this)
                {
                    if (tanks[i].CheckCollision(m_x, m_y - y, CConstants.tankSize))
                    {
                        ableToMoveY = false;
                    }
                }
            }
            if (ableToMoveY)
            {
                m_y -= y;
            }
        }
        public void Actions(List<CTank> tanks, List<CShell> shells)
        {
            if (IsDead())
            {
                m_reload = 0;
                return;
            }
            if (m_reload > 0)
            {
                m_reload--;
            }
            
            List<CTank> visibleEnemies = GetEnemies(tanks);
            int distance = -1;
            try
            {
                setcoords(Convert.ToInt32(m_x), Convert.ToInt32(m_y));
                setangle(m_baseDirection); 
                setturrentAngle(m_turretDirection);
                setcollisionstatus(DetectCollisions(tanks));
                setlivepercent(m_health);
                setvisibleenemycount(visibleEnemies.Count);
                for (int i = 0; i < visibleEnemies.Count; i++)
                {
                    setenemyproteries(i, Convert.ToInt32(visibleEnemies[i].m_x), Convert.ToInt32(visibleEnemies[i].m_y),
                        visibleEnemies[i].m_baseDirection, visibleEnemies[i].m_turretDirection, visibleEnemies[i].m_health);
                }
                update();
                m_baseDirection += Convert.ToInt32(getrotatedirection() * getrotatespeed() * CConstants.baseRotationRate + 360) % 360;
                TryToMoveForward(getdirection() * CConstants.tankSpeed * Math.Sin(m_baseDirection * Math.PI / 180),
                    getdirection() * CConstants.tankSpeed * Math.Cos(m_baseDirection * Math.PI / 180), tanks);
                FixCollisions(tanks);
                m_turretDirection += Convert.ToInt32(getturretrotatedirection() * getturretrotatespeed() * CConstants.turretRotationRate + 360) % 360;
                distance = getfiredistance();
            }
            catch
            {
                CConstants.error = 2;
                return;
            }
            if (distance != -1 && m_reload == 0)
            {
                shells.Add(new CShell(Convert.ToInt32(m_x), Convert.ToInt32(m_y), m_turretDirection, distance, this));
                m_reload = CConstants.reloadTime;
            }
        }
        public void Draw(Graphics graph)
        {
            if (m_destroyed)
            {
                return;
            }
            if (!IsDead())
            {
                graph.DrawImage(m_base, FBattleScreen.GetRotatedRectangle(m_baseDirection, CConstants.tankSize, m_x, m_y));
                graph.DrawImage(m_turret, FBattleScreen.GetRotatedRectangle(m_turretDirection, CConstants.turretSize, m_x, m_y));
            }
            else
            {
                graph.DrawImage(CConstants.wrecked, FBattleScreen.GetRotatedRectangle(m_baseDirection, CConstants.tankSize, m_x, m_y));
            }
        }
        public void SetTankInfo(ProgressBar pbHealth, ProgressBar pbReload, Label hits, Label condition, PictureBox pbox, GroupBox gb)
        {
            pbHealth.Value = m_health;
            pbReload.Value = m_reload * pbReload.Maximum / CConstants.reloadTime;
            hits.Text = Convert.ToString(m_hits);
            if (!IsDead())
            {
                condition.Text = "Still alive";
            }
            else
            {
                condition.Text = "Dead " + Convert.ToString(m_deadPlace);
            }
            pbox.Image = m_tank;
            gb.Visible = true;
        }
        public bool CheckCollision(double x, double y, int length)
        {
            if (!m_destroyed && Math.Abs(m_x - x) < length && Math.Abs(m_y - y) < length)
            {
                return true;
            }
            return false;
        }
        public bool FixCollisions(List<CTank> tanks)
        {
            bool result = false;
            if (m_x < CConstants.tankSize / 2)
            {
                m_x = CConstants.tankSize / 2;
                result = true;
            }
            if (m_x > CConstants.formWidth - CConstants.tankSize / 2)
            {
                m_x = CConstants.formWidth - CConstants.tankSize / 2;
                result = true;
            }
            if (m_y < CConstants.tankSize / 2)
            {
                m_y = CConstants.tankSize / 2;
                result = true;
            }
            if (m_y > CConstants.formHeight - CConstants.tankSize / 2)
            {
                m_y = CConstants.formHeight - CConstants.tankSize / 2;
                result = true;
            }
            for (int i = 0; i < tanks.Count; i++)
            {
                if (tanks[i].CheckCollision(m_x, m_y, CConstants.tankSize / 2) && !(m_x == tanks[i].m_x && m_y == tanks[i].m_y))
                {
                    result = true;
                }
            }
            return result;
        }
        public bool DetectCollisions(List<CTank> tanks)
        {
            if (m_x <= CConstants.tankSize / 2 || m_y <= CConstants.tankSize / 2 || m_x >= CConstants.formWidth - CConstants.tankSize / 2 ||
                m_y >= CConstants.formHeight - CConstants.tankSize / 2)
            {
                return true; //collision with borders
            }
            for (int i = 0; i < tanks.Count; i++)
            {
                if (tanks[i].CheckCollision(m_x, m_y, CConstants.tankSize + CConstants.tankSpeed))//collision with tanks
                {
                    if (!(tanks[i] == this))//it's not me
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void SetDamage(short damage)
        {
            if(m_health < 0)
            {
                return;
            }
            m_health -= damage;
            if (m_health < 0)
            {
                m_health = 0;
                FBattleScreen.PlaySound("player_death");
            }
        }
        public bool IsDead() { return m_health <= 0; }
        public void SetDeadPlace(short deadNumber) { m_deadPlace = deadNumber; }
        public void SuccessfulHit() { m_hits++; }
        IntPtr m_dll;
        SetCoords setcoords;
        SetAngle setangle;
        SetTurretAngle setturrentAngle;
        SetCollisionStatus setcollisionstatus;
        SetLivePercent setlivepercent;
        SetVisilbeEnemyCount setvisibleenemycount;
        SetEnemyProteries setenemyproteries;
        Update update;
        GetRotateDirection getrotatedirection;
        GetRotateSpeed getrotatespeed;
        GetDirection getdirection;
        GetTurretRotateDirection getturretrotatedirection;
        GetTurretRotateSpeed getturretrotatespeed;
        GetFireDistance getfiredistance;
        private bool m_destroyed;
        private readonly Image m_base;
        private readonly Image m_turret;
        private readonly Image m_tank;
        private double m_x;
        private double m_y;
        private short m_health;
        private short m_hits;
        private short m_reload;
        private int m_baseDirection;
        private int m_turretDirection;
        private short m_deadPlace;
    }
}