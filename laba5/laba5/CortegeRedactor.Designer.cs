namespace laba5
{
    partial class CortegeRedactor
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
            this.disciplineNameTextBox = new System.Windows.Forms.TextBox();
            this.lecturerNamTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closButtom = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disciplineNameTextBox
            // 
            this.disciplineNameTextBox.Location = new System.Drawing.Point(96, 33);
            this.disciplineNameTextBox.Name = "disciplineNameTextBox";
            this.disciplineNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.disciplineNameTextBox.TabIndex = 0;
            // 
            // lecturerNamTextBox
            // 
            this.lecturerNamTextBox.Location = new System.Drawing.Point(96, 6);
            this.lecturerNamTextBox.Name = "lecturerNamTextBox";
            this.lecturerNamTextBox.Size = new System.Drawing.Size(127, 20);
            this.lecturerNamTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "лектор";
            // 
            // closButtom
            // 
            this.closButtom.Location = new System.Drawing.Point(64, 72);
            this.closButtom.Name = "closButtom";
            this.closButtom.Size = new System.Drawing.Size(75, 23);
            this.closButtom.TabIndex = 4;
            this.closButtom.Text = "закрыть";
            this.closButtom.UseVisualStyleBackColor = true;
            this.closButtom.Click += new System.EventHandler(this.closButtom_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(148, 72);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CortegeRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 103);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.closButtom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lecturerNamTextBox);
            this.Controls.Add(this.disciplineNameTextBox);
            this.Name = "CortegeRedactor";
            this.Text = "CortegeRedactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox disciplineNameTextBox;
        private System.Windows.Forms.TextBox lecturerNamTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closButtom;
        private System.Windows.Forms.Button OKButton;
    }
}