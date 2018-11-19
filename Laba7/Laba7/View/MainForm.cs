using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laba7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cortegeDataGrid.AllowUserToDeleteRows = false;
            using (SqlConnection connection = new SqlConnection(Controller.Controller.connStr))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable table = (DataTable)Controller.Controller.GetDataTable(connection);
                cortegeDataGrid.DataSource = table;
            }
        }


        private void addCortegeButton_Click(object sender, EventArgs e)
        {
            if (disciplineIdTextBox.Text != null
                && lecturerIdTextBox.Text != null)
            {
                if (Controller.Controller.InsertCortege(int.Parse(lecturerIdTextBox.Text),
                    int.Parse(disciplineIdTextBox.Text)))
                {
                    UpdateCortegeGrid();
                }
                else MessageBox.Show("Неудачная операция");
            }
            else MessageBox.Show("Неудачная операция");
        }
        private void addDisciplineButton_Click(object sender, EventArgs e)
        {
            new AddDisciplineForm().Show();
            UpdateCortegeGrid();
        }
        private void addLecturerButton_Click(object sender, EventArgs e)
        {
            new AddLecturerForm().Show();
        }


        private void removeDisciplineButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.Controller.DeleteDiscipline(int.Parse(disciplineIdTextBox.Text)))
                {
                    UpdateCortegeGrid();
                }
                else MessageBox.Show("Неудачная операция");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неудачная операция");
            }
        }
        private void removeLectrrButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.Controller.DeleteDiscipline(int.Parse(lecturerIdTextBox.Text)))
                {
                    UpdateCortegeGrid();
                }
                else MessageBox.Show("Неудачная операция");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неудачная операция");
            }
        }
        private void deleteCortegeButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in cortegeDataGrid.SelectedRows)
            {
                Controller.Controller.DeleteCortege((int)row.Cells[0].Value, (int)row.Cells[1].Value);
            }
            UpdateCortegeGrid();
        }
        private void deleteCortegeByIdButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.Controller.DeleteCortege(int.Parse(lecturerIdTextBox.Text),
                    int.Parse(disciplineIdTextBox.Text)))
                {
                    UpdateCortegeGrid();
                }
                else MessageBox.Show("Неудачная операция");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неудачная операция");
            }
        }


        private void UpdateCortegeGrid()
        {
            using (SqlConnection connection = new SqlConnection(Controller.Controller.connStr))
            {
                DataTable table = (DataTable)Controller.Controller.GetDataTable(connection);
                cortegeDataGrid.DataSource = table;
            }
            cortegeDataGrid.Update();
        }
    }
}
