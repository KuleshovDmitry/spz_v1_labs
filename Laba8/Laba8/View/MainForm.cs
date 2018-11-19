using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using Laba8.Controller;

namespace Laba8
{
    public partial class MainForm : Form
    {
        string defWallpaper= null;
        Color defColor ;
        DialogResult result;
        public MainForm()
        {
            defWallpaper = WallpaperController.GetCurrentWallpaper();
            defColor = WallpaperController.GetColor();
            InitializeComponent();
        }

        private void selectColorButton_Click(object sender, EventArgs e)
        {
            result =  selectColorDialog.ShowDialog();
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            WallpaperController.SetColor(defColor);
            WallpaperController.SetWallpaper(defWallpaper, 0, 0);
            Close();
        }
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            WallpaperController.SetColor(defColor);
            WallpaperController.SetWallpaper(defWallpaper, 0, 0);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            defWallpaper = WallpaperController.GetCurrentWallpaper();
            defColor = WallpaperController.GetColor();
            WallpaperController.SetColor(defColor);
            WallpaperController.SetWallpaper(defWallpaper, 0, 0);
            Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK)
            { WallpaperController.SetColor(selectColorDialog.Color); }
        }
    }
}
