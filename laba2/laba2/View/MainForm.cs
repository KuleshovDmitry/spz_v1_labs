using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba2.Model;


namespace laba2
{
    public partial class MainForm : Form
    {
        CarShop carShop = new CarShop("name", "adress");
        public MainForm()
        {
            InitializeComponent();

            adressTextBox.Text = carShop.adress;
            nameTextBox.Text = carShop.name;
            nameAdressTaextBox.Text = carShop.ToString();
            totalSalaryTextBox.Text = carShop.totalSalary.ToString();
            annualIncomeTextBox.Text = carShop.getAnnualIncome().ToString();
            annualTaxTextBox.Text = carShop.getAnnualTax().ToString();
        }
        
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            carShop.addEmployee();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (carShop.numberOfEmployees == 0) { MessageBox.Show("нет сотрудников"); }
            else carShop--;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            carShop++;
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            carShop.name = nameTextBox.Text;

            nameAdressTaextBox.Text = carShop.ToString();
        }
        private void firingEmployeeButton_Click(object sender, EventArgs e)
        {
            if (carShop.numberOfEmployees == 0) { MessageBox.Show("нет сотрудников"); }
            else carShop.firingEmployee();
        }
        private void adressTextBox_TextChanged(object sender, EventArgs e)
        {
            carShop.adress = adressTextBox.Text;

            nameAdressTaextBox.Text = carShop.ToString();
        }
        private void getAnnualIncome_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carShop.getAnnualIncome().ToString());
        }
        private void getAnnualTax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carShop.getAnnualTax().ToString());
        }
        private void getTotalSalary_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carShop.totalSalary.ToString());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) {
                case 0:
                    comboBoxOut.Text = carShop.averageIncome.ToString();
                    break;
                case 1:
                    comboBoxOut.Text = carShop.totalSalary.ToString();
                    break;
                case 2:
                    comboBoxOut.Text = carShop.purchaseExpenses.ToString();
                    break;
            } }
    }
}
