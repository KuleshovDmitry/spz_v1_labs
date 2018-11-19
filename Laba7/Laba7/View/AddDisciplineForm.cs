using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba7
{
    public partial class AddDisciplineForm : Form
    {
        public AddDisciplineForm()
        {
            InitializeComponent();
        }

        private void OkBbutton_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.InsertDiscipline(int.Parse(idTextBox.Text),
                disciplineNameTextBox.Text))
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
