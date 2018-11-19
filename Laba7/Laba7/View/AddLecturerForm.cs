using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba7.Controller;

namespace Laba7
{
    public partial class AddLecturerForm : Form
    {
        public AddLecturerForm()
        {
            InitializeComponent();
        }

        private void OkBbutton_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.InsertLecturer(int.Parse(idTextBox.Text),
                firstNameTextBox.Text, lastNameTextBox.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Неудачная операция");
        }
        private void censleButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
