using System;
using System.Windows.Forms;

namespace laba5
{
    
    public partial class MainForm : Form
    {
        private Laba5Main main = new Laba5Main();
        public MainForm()
        {
            InitializeComponent();

            mainDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "lecturer",
                HeaderText = "лектор"
            });
            mainDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "discipline",
                HeaderText = "дисциплина"
            });

            mainDataGridView.DataSource = main.binding;
       }
        private void addCortegeBt_Click(object sender, EventArgs e)
        {
            AddCortegesDialog addCortegesDialog = new AddCortegesDialog();
            if (addCortegesDialog.ShowDialog() == DialogResult.OK)
            {
                main.addCortege(addCortegesDialog.lecturer, addCortegesDialog.discipline);
            }

        }
        private void deleteDisciplineButton_Click(object sender, EventArgs e)
        {
            RemoveDisciplineForm removeDisciplineForm = new RemoveDisciplineForm();

            if (removeDisciplineForm.ShowDialog() == DialogResult.OK)
            {
                main.removeDiscipline(removeDisciplineForm.disciplineName);
            }
        }
        private void deleteLecturerButton_Click(object sender, EventArgs e)
        {
            RemoveLecturerForm removeLecturerForm = new RemoveLecturerForm();
            if (removeLecturerForm.ShowDialog() == DialogResult.OK)
            {
                main.removeLecturer(removeLecturerForm.lecturerName);
            }
        }
        private void sortByLecturerButton_Click(object sender, EventArgs e)
        {
            main.sortByLecturer();
        }
        private void sortByDsciplineButton_Click(object sender, EventArgs e)
        {
            main.sortByDscipline();
        }
        private void mainDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CortegeRedactor cortegeRedactor = 
                new CortegeRedactor(main.data[mainDataGridView.CurrentRow.Index]);
            ;
            if (cortegeRedactor.ShowDialog() == DialogResult.OK)
            {
                main.changeCortege(mainDataGridView.CurrentRow.Index);
            }
        }
        private void serializeButton_Click(object sender, EventArgs e)
        {
            main.doXMLSerialize();
        }
        private void deserializeButton_Click(object sender, EventArgs e)
        {
            main.doXMLSerialize();
        }

    }
}
