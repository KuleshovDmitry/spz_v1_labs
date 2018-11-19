using System;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Laba8.Controller
{
    class User32Methods
    {
        public const int COLOR_DESKTOP = 1;
        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_UPDATEINIFILE = 0x01;
        public const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll")]
        public static extern bool SetSysColors(int cElements, int[] lpaElements, int[] lpaRgbValues);
        [DllImport("user32.dll")]
        public static extern int GetSysColor(int cElements);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo
            (int uAction, int uParam, string lpvParam, int fuWinIni);
    }
}
