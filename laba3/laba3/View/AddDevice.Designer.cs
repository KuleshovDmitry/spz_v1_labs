namespace laba3
{
    partial class AddDevice
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
            this.deviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.deviceNameTxtBx = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deviceTypeComboBox
            // 
            this.deviceTypeComboBox.FormattingEnabled = true;
            this.deviceTypeComboBox.Location = new System.Drawing.Point(150, 12);
            this.deviceTypeComboBox.Name = "deviceTypeComboBox";
            this.deviceTypeComboBox.Size = new System.Drawing.Size(132, 21);
            this.deviceTypeComboBox.TabIndex = 0;
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(150, 208);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(132, 23);
            this.addDeviceButton.TabIndex = 1;
            this.addDeviceButton.Text = "добавить устройство";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // deviceNameTxtBx
            // 
            this.deviceNameTxtBx.Location = new System.Drawing.Point(12, 12);
            this.deviceNameTxtBx.Name = "deviceNameTxtBx";
            this.deviceNameTxtBx.Size = new System.Drawing.Size(132, 20);
            this.deviceNameTxtBx.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 208);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 243);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deviceNameTxtBx);
            this.Controls.Add(this.addDeviceButton);
            this.Controls.Add(this.deviceTypeComboBox);
            this.Name = "AddDevice";
            this.Text = "AddDevice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deviceTypeComboBox;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.TextBox deviceNameTxtBx;
        private System.Windows.Forms.Button closeButton;
    }
}