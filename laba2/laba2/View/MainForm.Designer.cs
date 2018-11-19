namespace laba2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.nameAdressTaextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.firingEmployeeButton = new System.Windows.Forms.Button();
            this.getAnnualIncome = new System.Windows.Forms.Button();
            this.getAnnualTax = new System.Windows.Forms.Button();
            this.getTotalSalary = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.totalSalaryTextBox = new System.Windows.Forms.TextBox();
            this.annualTaxTextBox = new System.Windows.Forms.TextBox();
            this.annualIncomeTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(478, 11);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Нанять";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(478, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "++";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(585, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "--";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameAdressTaextBox
            // 
            this.nameAdressTaextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAdressTaextBox.Location = new System.Drawing.Point(12, 12);
            this.nameAdressTaextBox.Name = "nameAdressTaextBox";
            this.nameAdressTaextBox.ReadOnly = true;
            this.nameAdressTaextBox.Size = new System.Drawing.Size(414, 31);
            this.nameAdressTaextBox.TabIndex = 3;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(118, 65);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(100, 20);
            this.adressTextBox.TabIndex = 4;
            this.adressTextBox.TextChanged += new System.EventHandler(this.adressTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // firingEmployeeButton
            // 
            this.firingEmployeeButton.Location = new System.Drawing.Point(585, 11);
            this.firingEmployeeButton.Name = "firingEmployeeButton";
            this.firingEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.firingEmployeeButton.TabIndex = 6;
            this.firingEmployeeButton.Text = "Уволить";
            this.firingEmployeeButton.UseVisualStyleBackColor = true;
            this.firingEmployeeButton.Click += new System.EventHandler(this.firingEmployeeButton_Click);
            // 
            // getAnnualIncome
            // 
            this.getAnnualIncome.Location = new System.Drawing.Point(478, 94);
            this.getAnnualIncome.Name = "getAnnualIncome";
            this.getAnnualIncome.Size = new System.Drawing.Size(133, 23);
            this.getAnnualIncome.TabIndex = 7;
            this.getAnnualIncome.Text = "Годовой доход";
            this.getAnnualIncome.UseVisualStyleBackColor = true;
            this.getAnnualIncome.Click += new System.EventHandler(this.getAnnualIncome_Click);
            // 
            // getAnnualTax
            // 
            this.getAnnualTax.Location = new System.Drawing.Point(478, 123);
            this.getAnnualTax.Name = "getAnnualTax";
            this.getAnnualTax.Size = new System.Drawing.Size(133, 23);
            this.getAnnualTax.TabIndex = 8;
            this.getAnnualTax.Text = "Годовой налог";
            this.getAnnualTax.UseVisualStyleBackColor = true;
            this.getAnnualTax.Click += new System.EventHandler(this.getAnnualTax_Click);
            // 
            // getTotalSalary
            // 
            this.getTotalSalary.Location = new System.Drawing.Point(478, 152);
            this.getTotalSalary.Name = "getTotalSalary";
            this.getTotalSalary.Size = new System.Drawing.Size(133, 23);
            this.getTotalSalary.TabIndex = 9;
            this.getTotalSalary.Text = "Расходы на зарплату";
            this.getTotalSalary.UseVisualStyleBackColor = true;
            this.getTotalSalary.Click += new System.EventHandler(this.getTotalSalary_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "averageIncome",
            "totalSalary",
            "purchaseExpenses"});
            this.comboBox1.Location = new System.Drawing.Point(478, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // totalSalaryTextBox
            // 
            this.totalSalaryTextBox.Location = new System.Drawing.Point(617, 149);
            this.totalSalaryTextBox.Name = "totalSalaryTextBox";
            this.totalSalaryTextBox.ReadOnly = true;
            this.totalSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSalaryTextBox.TabIndex = 11;
            // 
            // annualTaxTextBox
            // 
            this.annualTaxTextBox.Location = new System.Drawing.Point(617, 123);
            this.annualTaxTextBox.Name = "annualTaxTextBox";
            this.annualTaxTextBox.ReadOnly = true;
            this.annualTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualTaxTextBox.TabIndex = 12;
            // 
            // annualIncomeTextBox
            // 
            this.annualIncomeTextBox.Location = new System.Drawing.Point(617, 97);
            this.annualIncomeTextBox.Name = "annualIncomeTextBox";
            this.annualIncomeTextBox.ReadOnly = true;
            this.annualIncomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualIncomeTextBox.TabIndex = 13;
            // 
            // comboBoxOut
            // 
            this.comboBoxOut.Location = new System.Drawing.Point(617, 181);
            this.comboBoxOut.Name = "comboBoxOut";
            this.comboBoxOut.ReadOnly = true;
            this.comboBoxOut.Size = new System.Drawing.Size(100, 20);
            this.comboBoxOut.TabIndex = 14;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(742, 297);
            this.Controls.Add(this.comboBoxOut);
            this.Controls.Add(this.annualIncomeTextBox);
            this.Controls.Add(this.annualTaxTextBox);
            this.Controls.Add(this.totalSalaryTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.getTotalSalary);
            this.Controls.Add(this.getAnnualTax);
            this.Controls.Add(this.getAnnualIncome);
            this.Controls.Add(this.firingEmployeeButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.nameAdressTaextBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.addEmployeeButton);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox nameAdressTaextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button firingEmployeeButton;
        private System.Windows.Forms.Button getAnnualIncome;
        private System.Windows.Forms.Button getAnnualTax;
        private System.Windows.Forms.Button getTotalSalary;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox totalSalaryTextBox;
        private System.Windows.Forms.TextBox annualTaxTextBox;
        private System.Windows.Forms.TextBox annualIncomeTextBox;
        private System.Windows.Forms.TextBox comboBoxOut;
    }
}

