namespace laba3
{
    partial class DriversCompare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.compareResponseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.LComboBox = new System.Windows.Forms.ComboBox();
            this.RComboBox = new System.Windows.Forms.ComboBox();
            this.version = new System.Windows.Forms.Label();
            this.supOS = new System.Windows.Forms.Label();
            this.rDriverVersion = new System.Windows.Forms.TextBox();
            this.lDriverVersion = new System.Windows.Forms.TextBox();
            this.rDriverSupOS = new System.Windows.Forms.ListBox();
            this.lDriverSupOS = new System.Windows.Forms.ListBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compareResponseTextBox
            // 
            this.compareResponseTextBox.Location = new System.Drawing.Point(15, 172);
            this.compareResponseTextBox.Name = "compareResponseTextBox";
            this.compareResponseTextBox.ReadOnly = true;
            this.compareResponseTextBox.Size = new System.Drawing.Size(333, 20);
            this.compareResponseTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 261);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // LComboBox
            // 
            this.LComboBox.FormattingEnabled = true;
            this.LComboBox.Location = new System.Drawing.Point(354, 12);
            this.LComboBox.Name = "LComboBox";
            this.LComboBox.Size = new System.Drawing.Size(213, 21);
            this.LComboBox.TabIndex = 7;
            this.LComboBox.SelectedIndexChanged += new System.EventHandler(this.LComboBox_SelectedIndexChanged);
            // 
            // RComboBox
            // 
            this.RComboBox.FormattingEnabled = true;
            this.RComboBox.Location = new System.Drawing.Point(134, 12);
            this.RComboBox.Name = "RComboBox";
            this.RComboBox.Size = new System.Drawing.Size(214, 21);
            this.RComboBox.TabIndex = 8;
            this.RComboBox.SelectedIndexChanged += new System.EventHandler(this.RComboBox_SelectedIndexChanged);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(12, 198);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(75, 13);
            this.version.TabIndex = 9;
            this.version.Text = "имя и версия";
            // 
            // supOS
            // 
            this.supOS.AutoSize = true;
            this.supOS.Location = new System.Drawing.Point(12, 229);
            this.supOS.Name = "supOS";
            this.supOS.Size = new System.Drawing.Size(115, 13);
            this.supOS.TabIndex = 10;
            this.supOS.Text = "поддерживаемые ОС";
            // 
            // rDriverVersion
            // 
            this.rDriverVersion.Location = new System.Drawing.Point(134, 198);
            this.rDriverVersion.Name = "rDriverVersion";
            this.rDriverVersion.ReadOnly = true;
            this.rDriverVersion.Size = new System.Drawing.Size(214, 20);
            this.rDriverVersion.TabIndex = 13;
            // 
            // lDriverVersion
            // 
            this.lDriverVersion.Location = new System.Drawing.Point(354, 198);
            this.lDriverVersion.Name = "lDriverVersion";
            this.lDriverVersion.ReadOnly = true;
            this.lDriverVersion.Size = new System.Drawing.Size(213, 20);
            this.lDriverVersion.TabIndex = 14;
            // 
            // rDriverSupOS
            // 
            this.rDriverSupOS.FormattingEnabled = true;
            this.rDriverSupOS.Location = new System.Drawing.Point(134, 224);
            this.rDriverSupOS.Name = "rDriverSupOS";
            this.rDriverSupOS.Size = new System.Drawing.Size(214, 69);
            this.rDriverSupOS.TabIndex = 15;
            // 
            // lDriverSupOS
            // 
            this.lDriverSupOS.FormattingEnabled = true;
            this.lDriverSupOS.Location = new System.Drawing.Point(354, 224);
            this.lDriverSupOS.Name = "lDriverSupOS";
            this.lDriverSupOS.Size = new System.Drawing.Size(214, 69);
            this.lDriverSupOS.TabIndex = 16;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(8, 10);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(75, 23);
            this.compareButton.TabIndex = 17;
            this.compareButton.Text = "сравнить";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // DriversCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 296);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.lDriverSupOS);
            this.Controls.Add(this.rDriverSupOS);
            this.Controls.Add(this.lDriverVersion);
            this.Controls.Add(this.rDriverVersion);
            this.Controls.Add(this.supOS);
            this.Controls.Add(this.version);
            this.Controls.Add(this.RComboBox);
            this.Controls.Add(this.LComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compareResponseTextBox);
            this.Name = "DriversCompare";
            this.Text = "DriversCompare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox compareResponseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox LComboBox;
        private System.Windows.Forms.ComboBox RComboBox;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label supOS;
        private System.Windows.Forms.TextBox rDriverVersion;
        private System.Windows.Forms.TextBox lDriverVersion;
        private System.Windows.Forms.ListBox rDriverSupOS;
        private System.Windows.Forms.ListBox lDriverSupOS;
        private System.Windows.Forms.Button compareButton;
    }
}