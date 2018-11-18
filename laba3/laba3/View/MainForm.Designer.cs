namespace laba3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteDriver = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.generation = new System.Windows.Forms.Button();
            this.deleteDevice = new System.Windows.Forms.Button();
            this.addDevice = new System.Windows.Forms.Button();
            this.driversLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.driverListBox = new System.Windows.Forms.ListBox();
            this.deviceListBox = new System.Windows.Forms.ListBox();
            this.addDriverButton = new System.Windows.Forms.Button();
            this.isReadyTextBox = new System.Windows.Forms.TextBox();
            this.pcIsReady = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteDriver
            // 
            this.deleteDriver.Location = new System.Drawing.Point(40, 268);
            this.deleteDriver.Name = "deleteDriver";
            this.deleteDriver.Size = new System.Drawing.Size(135, 23);
            this.deleteDriver.TabIndex = 2;
            this.deleteDriver.Text = "удалить";
            this.deleteDriver.UseVisualStyleBackColor = true;
            this.deleteDriver.Click += new System.EventHandler(this.deleteDriver_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(191, 268);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(135, 23);
            this.equals.TabIndex = 3;
            this.equals.Text = "сравнить";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // generation
            // 
            this.generation.Location = new System.Drawing.Point(40, 239);
            this.generation.Name = "generation";
            this.generation.Size = new System.Drawing.Size(135, 23);
            this.generation.TabIndex = 4;
            this.generation.Text = "генерация драйверов";
            this.generation.UseVisualStyleBackColor = true;
            this.generation.Click += new System.EventHandler(this.generation_Click);
            // 
            // deleteDevice
            // 
            this.deleteDevice.Location = new System.Drawing.Point(564, 239);
            this.deleteDevice.Name = "deleteDevice";
            this.deleteDevice.Size = new System.Drawing.Size(135, 23);
            this.deleteDevice.TabIndex = 5;
            this.deleteDevice.Text = "удалить";
            this.deleteDevice.UseVisualStyleBackColor = true;
            this.deleteDevice.Click += new System.EventHandler(this.deleteDevice_Click);
            // 
            // addDevice
            // 
            this.addDevice.Location = new System.Drawing.Point(413, 239);
            this.addDevice.Name = "addDevice";
            this.addDevice.Size = new System.Drawing.Size(135, 23);
            this.addDevice.TabIndex = 6;
            this.addDevice.Text = "добавить";
            this.addDevice.UseVisualStyleBackColor = true;
            this.addDevice.Click += new System.EventHandler(this.addDevice_Click);
            // 
            // driversLabel
            // 
            this.driversLabel.AutoSize = true;
            this.driversLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.driversLabel.Location = new System.Drawing.Point(121, 37);
            this.driversLabel.Name = "driversLabel";
            this.driversLabel.Size = new System.Drawing.Size(121, 25);
            this.driversLabel.TabIndex = 9;
            this.driversLabel.Text = "ДРАЙВЕРЫ";
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deviceLabel.Location = new System.Drawing.Point(489, 37);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(140, 25);
            this.deviceLabel.TabIndex = 10;
            this.deviceLabel.Text = "УСТРОЙСТВА";
            // 
            // driverListBox
            // 
            this.driverListBox.FormattingEnabled = true;
            this.driverListBox.Location = new System.Drawing.Point(40, 65);
            this.driverListBox.Name = "driverListBox";
            this.driverListBox.Size = new System.Drawing.Size(286, 173);
            this.driverListBox.TabIndex = 11;
            this.driverListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.driverListBox_MouseDoubleClick);
            // 
            // deviceListBox
            // 
            this.deviceListBox.FormattingEnabled = true;
            this.deviceListBox.Location = new System.Drawing.Point(413, 65);
            this.deviceListBox.Name = "deviceListBox";
            this.deviceListBox.Size = new System.Drawing.Size(286, 173);
            this.deviceListBox.TabIndex = 12;
            this.deviceListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.deviceListBox_MouseDoubleClick);
            // 
            // addDriverButton
            // 
            this.addDriverButton.Location = new System.Drawing.Point(191, 239);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(135, 23);
            this.addDriverButton.TabIndex = 13;
            this.addDriverButton.Text = "добавить";
            this.addDriverButton.UseVisualStyleBackColor = true;
            this.addDriverButton.Click += new System.EventHandler(this.addDriverButton_Click);
            // 
            // isReadyTextBox
            // 
            this.isReadyTextBox.Location = new System.Drawing.Point(229, 297);
            this.isReadyTextBox.Name = "isReadyTextBox";
            this.isReadyTextBox.ReadOnly = true;
            this.isReadyTextBox.Size = new System.Drawing.Size(97, 20);
            this.isReadyTextBox.TabIndex = 14;
            // 
            // pcIsReady
            // 
            this.pcIsReady.AutoSize = true;
            this.pcIsReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pcIsReady.Location = new System.Drawing.Point(37, 297);
            this.pcIsReady.Name = "pcIsReady";
            this.pcIsReady.Size = new System.Drawing.Size(186, 16);
            this.pcIsReady.TabIndex = 15;
            this.pcIsReady.Text = "ПК готов к использованию:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.pcIsReady);
            this.Controls.Add(this.isReadyTextBox);
            this.Controls.Add(this.addDriverButton);
            this.Controls.Add(this.deviceListBox);
            this.Controls.Add(this.driverListBox);
            this.Controls.Add(this.deviceLabel);
            this.Controls.Add(this.driversLabel);
            this.Controls.Add(this.addDevice);
            this.Controls.Add(this.deleteDevice);
            this.Controls.Add(this.generation);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.deleteDriver);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deleteDriver;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button generation;
        private System.Windows.Forms.Button deleteDevice;
        private System.Windows.Forms.Button addDevice;
        private System.Windows.Forms.Label driversLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.ListBox driverListBox;
        private System.Windows.Forms.ListBox deviceListBox;
        private System.Windows.Forms.Button addDriverButton;
        private System.Windows.Forms.TextBox isReadyTextBox;
        private System.Windows.Forms.Label pcIsReady;
    }
}

