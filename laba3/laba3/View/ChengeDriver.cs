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
    public partial class ChangeDriver : Form
    {
        public Driver driver { get; private set; }
        public ChangeDriver()
        {
            InitializeComponent();
            for (int i = 0; i < 12; i++)
            {
                deviceTypeComboBox.Items.Add((EnumDeviceType)i);
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if ((Object)nameTextBox.Text != null &&
                (Object)deviceTypeComboBox.SelectedItem != null)
            {
                driver = new Driver(nameTextBox.Text, (EnumDeviceType)deviceTypeComboBox.SelectedItem, (int)versionUpDown.Value);
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
