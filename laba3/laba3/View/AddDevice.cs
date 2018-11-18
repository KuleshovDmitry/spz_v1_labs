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
    public partial class AddDevice : Form
    {
        public Device device { get; private set; }
        public AddDevice()
        {
            InitializeComponent();
            for (int i = 0; i < 12; i++)
            {
                deviceTypeComboBox.Items.Add((EnumDeviceType)i);
            }
        }
        private void addDeviceButton_Click(object sender, EventArgs e)
        {

            if ((Object)deviceNameTxtBx.Text != null &&
                (Object)deviceTypeComboBox.SelectedItem != null)
            {
                device = new Device(deviceNameTxtBx.Text, (EnumDeviceType)deviceTypeComboBox.SelectedItem);
                DialogResult = DialogResult.OK;
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
