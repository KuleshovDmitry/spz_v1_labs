using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;


namespace laba6
{
     public partial class Form1 : Form
    {
        MarktManager manager = new MarktManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void traidingButton_Click(object sender, EventArgs e)
        {
            tradingButton.Enabled = false;
            purchaseButton.Enabled = true;
            manager.traiding();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            tradingButton.Enabled = true;
            purchaseButton.Enabled = false;
            manager.purchase();
            textBox1.Text = manager.getCurrentAmount().ToString();
        }

        private void viewReportsButton_Click(object sender, EventArgs e)
        {
            new ViewReportsForm().Show();
        }


    }
}
