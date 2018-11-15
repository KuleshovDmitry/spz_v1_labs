using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5
{
    public partial class RemoveLecturerForm : Form
    {
        public string lecturerName { get; private set; }
        public RemoveLecturerForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            lecturerName = lecturerNameTextBox.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
