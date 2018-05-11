using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;

namespace BattleCity.NET
{
    class CConstants
    {
        static CConstants()
        {
            error = 0;
            try
            {
                explosion = Image.FromFile(@"Images\explosion.png");
                shell = Image.FromFile(@"Images\shell.png");
                wrecked = Image.FromFile(@"Images\wrecked.png");
            }
            catch
            {
                error = 1;
                return;
            }
            explosion = explosion.GetThumbnailImage(CConstants.tankSize, CConstants.tankSize, null, IntPtr.Zero);
            shell = shell.GetThumbnailImage(CConstants.shellSize, CConstants.shellSize, null, IntPtr.Zero);
            wrecked = wrecked.GetThumbnailImage(CConstants.tankSize, CConstants.tankSize, null, IntPtr.Zero);
        }
        public const int refreshTime = 20;
        public const int tankSize = 64;
        public const int turretSize = 80;
        public const int formWidth = 640;
        public const int formHeight = 480;
        public const int tankSpeed = refreshTime / 10;
        public const double baseRotationRate = 0.01 * refreshTime;
        public const double turretRotationRate = 0.01 * refreshTime;
        public const int reloadTime = 5000 / refreshTime;
        public const int shellSpeed = refreshTime;
        public const int shellSize = 16;
        public const int explodeTime = 200 / refreshTime;
        public readonly static Image explosion;
        public readonly static Image shell;
        public readonly static Image wrecked;
        public static int error;
    }
}