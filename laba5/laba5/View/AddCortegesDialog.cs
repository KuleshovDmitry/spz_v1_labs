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

    public partial class AddCortegesDialog : Form
    {
        public Discipline discipline { get; private set; }
        public Lecturer lecturer { get; private set; }
        public AddCortegesDialog()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            lecturer = new Lecturer(lecturersTextBox.Text);
            discipline = new Discipline( disciplinesTextBox.Text);
            if (lecturersTextBox.Text != "" && disciplinesTextBox.Text != "")
            { DialogResult = DialogResult.OK; }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
