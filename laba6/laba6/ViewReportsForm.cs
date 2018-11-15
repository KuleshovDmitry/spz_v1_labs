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
    public partial class ViewReportsForm : Form
    {
        List<Market> marketState;
        public ViewReportsForm()
        {
            
            using (FileStream file = new FileStream("laba6.xml", FileMode.Open))
            {
                marketState = new XmlSerializer(typeof(List<Market>)).Deserialize(file) as List<Market>;
            }
            InitializeComponent();

            slectDayUpDown.Maximum = marketState.Count-1;
            slectDayUpDown.Minimum = 0;
        }

        private void slectDayUpDown_ValueChanged(object sender, EventArgs e)
        {
            productsListBox.Items.Clear();

            foreach (Product product in marketState[(int)slectDayUpDown.Value].productsSet)
            {
                productsListBox.Items.Add(product);
            }
            currentAmountTextBox.Text = 
                marketState[(int)slectDayUpDown.Value].currentAmount.ToString();
            numberBuyersTextBox.Text = 
                marketState[(int)slectDayUpDown.Value].buyers.ToString();
            
        }
    }
}
