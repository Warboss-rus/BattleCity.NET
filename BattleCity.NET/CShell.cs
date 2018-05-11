using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BattleCity.NET
{
    class CShell
    {
        public CShell(int x, int y, int direction, int range, CTank owner)
        {
            m_x = x;
            m_y = y;
            m_direction = direction;
            m_range = range;
            m_owner = owner;
            FBattleScreen.PlaySound("shot");
        }
        public void MoveShell()
        {
            if (m_range <= CConstants.shellSpeed)
            {
                m_x -= Convert.ToInt32(m_range * -Math.Sin(m_direction * Math.PI / 180));
                m_y -= Convert.ToInt32(m_range * Math.Cos(m_direction * Math.PI / 180));
                m_range = 0;
                return;
            }
            m_x -= Convert.ToInt32(CConstants.shellSpeed * -Math.Sin(m_direction * Math.PI / 180));
            m_y -= Convert.ToInt32(CConstants.shellSpeed * Math.Cos(m_direction * Math.PI / 180));
            m_range -= CConstants.shellSpeed;
        }
        public bool OutOfField()
        {
            if (m_x < 0 || m_x > CConstants.formWidth || m_y < 0 || m_y > CConstants.formHeight)
            {
                return true;
            }
            return false;
        }
        public bool IsExploded()
        {
            return m_range == 0;
        }
        public void Draw(Graphics graph)
        {
            graph.DrawImage(CConstants.shell, FBattleScreen.GetRotatedRectangle(m_direction, CConstants.shellSize, m_x, m_y));
        }
        public CExplosion GetExplosion()
        {
            return new CExplosion(Convert.ToInt32(m_x), Convert.ToInt32(m_y));
        }
        public double GetX() { return m_x; }
        public double GetY() { return m_y; }
        public void SuccessfulyHits() { m_owner.SuccessfulHit(); }
        
        private double m_x;
        private double m_y;
        private int m_direction;
        private int m_range;
        private CTank m_owner;
    }
}