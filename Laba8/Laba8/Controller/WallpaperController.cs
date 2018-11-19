using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;

namespace Laba8.Controller
{
    public static class WallpaperController
    {
        public static void SetColor(Color color)
        {
            User32Methods.SystemParametersInfo( User32Methods.SPI_SETDESKWALLPAPER, 0, "" ,
                User32Methods.SPIF_UPDATEINIFILE | User32Methods.SPIF_SENDWININICHANGE);
            
            int[] elements = { User32Methods.COLOR_DESKTOP };
            int[] colors = { System.Drawing.ColorTranslator.ToWin32(color) };
            User32Methods.SetSysColors(elements.Length, elements, colors);

            RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Colors", true);
            key.SetValue(@"Background", string.Format("{0} {1} {2}", color.R, color.G, color.B));
        }
        public static void SetWallpaper(string WallpaperLocation, int WallpaperStyle, int TileWallpaper)
        {
            RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            rkWallPaper.SetValue("WallpaperStyle", 2);
            rkWallPaper.SetValue("TileWallpaper", TileWallpaper);

            User32Methods.SystemParametersInfo(20, 0, WallpaperLocation, 0x01 | 0x02);
            rkWallPaper.Close();
        }
        public static string GetCurrentWallpaper()
        {
            RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", false);
            string WallpaperPath = rkWallPaper.GetValue("WallPaper").ToString();
            rkWallPaper.Close();
            return WallpaperPath;
        }
        public static Color GetColor()
        {
            return Color.FromArgb(User32Methods.GetSysColor(User32Methods.COLOR_DESKTOP));
        }
    }
}

