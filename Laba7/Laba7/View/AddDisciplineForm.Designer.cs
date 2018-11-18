namespace Laba7
{
    partial class AddDisciplineForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.OkBbutton = new System.Windows.Forms.Button();
            this.censleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.disciplineNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(156, 63);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 10;
            // 
            // OkBbutton
            // 
            this.OkBbutton.Location = new System.Drawing.Point(237, 112);
            this.OkBbutton.Name = "OkBbutton";
            this.OkBbutton.Size = new System.Drawing.Size(75, 23);
            this.OkBbutton.TabIndex = 9;
            this.OkBbutton.Text = "OK";
            this.OkBbutton.UseVisualStyleBackColor = true;
            this.OkBbutton.Click += new System.EventHandler(this.OkBbutton_Click);
            // 
            // censleButton
            // 
            this.censleButton.Location = new System.Drawing.Point(156, 112);
            this.censleButton.Name = "censleButton";
            this.censleButton.Size = new System.Drawing.Size(75, 23);
            this.censleButton.TabIndex = 8;
            this.censleButton.Text = "Censle";
            this.censleButton.UseVisualStyleBackColor = true;
            this.censleButton.Click += new System.EventHandler(this.censleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "название предмета";
            // 
            // disciplineNameTextBox
            // 
            this.disciplineNameTextBox.Location = new System.Drawing.Point(156, 37);
            this.disciplineNameTextBox.Name = "disciplineNameTextBox";
            this.disciplineNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.disciplineNameTextBox.TabIndex = 13;
            // 
            // AddDisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 142);
            this.Controls.Add(this.disciplineNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.OkBbutton);
            this.Controls.Add(this.censleButton);
            this.Name = "AddDisciplineForm";
            this.Text = "AddDisciplineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button OkBbutton;
        private System.Windows.Forms.Button censleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox disciplineNameTextBox;
    }
}