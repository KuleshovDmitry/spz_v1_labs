
using System.Windows.Forms;


namespace laba3
{
    public partial class ChangeDriver : Form
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
            this.closeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.deviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.versionUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.versionUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 208);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(93, 208);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "принять";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // deviceTypeComboBox
            // 
            this.deviceTypeComboBox.FormattingEnabled = true;
            this.deviceTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.deviceTypeComboBox.Name = "deviceTypeComboBox";
            this.deviceTypeComboBox.Size = new System.Drawing.Size(156, 21);
            this.deviceTypeComboBox.TabIndex = 2;
            // 
            // versionUpDown
            // 
            this.versionUpDown.Location = new System.Drawing.Point(12, 182);
            this.versionUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.versionUpDown.Name = "versionUpDown";
            this.versionUpDown.Size = new System.Drawing.Size(156, 20);
            this.versionUpDown.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(156, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // ChangeDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 243);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.versionUpDown);
            this.Controls.Add(this.deviceTypeComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.closeButton);
            this.Name = "ChangeDriver";
            this.Text = "ChengeDriver";
            ((System.ComponentModel.ISupportInitialize)(this.versionUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox deviceTypeComboBox;
        private System.Windows.Forms.NumericUpDown versionUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}