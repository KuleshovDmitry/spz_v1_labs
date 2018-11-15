using System;
using System.Windows.Forms;

namespace laba5
{
    public partial class CortegeRedactor : Form
    {
        public bool isChangeLect { get; private set; } = false;
        public bool isChangeDisc { get; private set; } = false;
        CrutchCortege crutchCortege;
        public CortegeRedactor(CrutchCortege crutchCortege)
        {
            this.crutchCortege = crutchCortege;
            InitializeComponent();
            lecturerNamTextBox.Text = crutchCortege.lecturer.name;
            disciplineNameTextBox.Text = crutchCortege.discipline.name;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            
            if (lecturerNamTextBox.Text != "" && disciplineNameTextBox.Text != "")
            {
                if (!crutchCortege.lecturer.name.Equals(lecturerNamTextBox.Text))
                {
                    isChangeLect = true;
                    crutchCortege.lecturer = new Lecturer(lecturerNamTextBox.Text);
                }
                if (!crutchCortege.discipline.name.Equals(disciplineNameTextBox.Text))
                {
                    isChangeDisc = true;
                    crutchCortege.discipline = new Discipline(disciplineNameTextBox.Text);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void closButtom_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
