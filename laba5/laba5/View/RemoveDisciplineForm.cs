using System;
using System.Windows.Forms;

namespace laba5
{
    public partial class RemoveDisciplineForm : Form
    {
        public string disciplineName { get; private set; }
        public RemoveDisciplineForm()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            disciplineName = disciplineTextBox.Text;
            DialogResult = DialogResult.OK;
                 
        }
    }
}
