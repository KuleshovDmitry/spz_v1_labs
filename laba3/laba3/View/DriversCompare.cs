using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class DriversCompare : Form
    {
        private Dictionary<string, Driver> driverMap = new Dictionary<string, Driver>();
        public DriversCompare(Dictionary<string, Driver> driverMap)
        {
            this.driverMap = driverMap;
            InitializeComponent();
            foreach (Driver driverIt in driverMap.Values)
            {
                LComboBox.Items.Add(driverIt);
                RComboBox.Items.Add(driverIt);
            }
        }
        private void compareSelect()
        {
            if ((Object)LComboBox.SelectedItem != null &&
                (Object)RComboBox.SelectedItem != null)
            {
                Driver lSelectDriver = (Driver)LComboBox.SelectedItem;
                Driver rSelectDriver = (Driver)RComboBox.SelectedItem;
                if (lSelectDriver.deviceType != rSelectDriver.deviceType)
                    compareResponseTextBox.Text = "невозможно сравнить: разные устройства";
                else
                {
                    lDriverSupOS.Items.Clear();
                    rDriverSupOS.Items.Clear();
                    compareResponseTextBox.Text = "драйверы для " + rSelectDriver.deviceType.ToString();
                    lDriverVersion.Text = lSelectDriver.name + lSelectDriver.version.ToString();
                    rDriverVersion.Text = rSelectDriver.name + rSelectDriver.version.ToString();
                    foreach (string s in lSelectDriver.supportingOS)
                    {
                        lDriverSupOS.Items.Add((string)s);
                    }
                    foreach (string s in rSelectDriver.supportingOS)
                    {
                        rDriverSupOS.Items.Add((string)s);
                    }
                }
            }
           
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            compareSelect();
        }
        private void LComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            compareSelect();
        }

        private void compareButton_Click(object sender, EventArgs e)
        {

            compareSelect();
        }
    }
}
