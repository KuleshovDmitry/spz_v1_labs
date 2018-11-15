namespace laba5
{
    partial class RemoveDisciplineForm
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
            this.Closebutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.disciplineTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(89, 51);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(75, 23);
            this.Closebutton.TabIndex = 0;
            this.Closebutton.Text = "Закрыть";
            this.Closebutton.UseVisualStyleBackColor = true;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(170, 51);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // disciplineTextBox
            // 
            this.disciplineTextBox.Location = new System.Drawing.Point(15, 25);
            this.disciplineTextBox.Name = "disciplineTextBox";
            this.disciplineTextBox.Size = new System.Drawing.Size(222, 20);
            this.disciplineTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "введите дисциплину";
            // 
            // RemoveDisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 94);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disciplineTextBox);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Closebutton);
            this.Name = "RemoveDisciplineForm";
            this.Text = "RemoveDisciplineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.TextBox disciplineTextBox;
        private System.Windows.Forms.Label label1;
    }
}