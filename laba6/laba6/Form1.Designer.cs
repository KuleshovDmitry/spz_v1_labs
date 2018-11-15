namespace laba6
{
    partial class Form1
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
            this.tradingButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.viewReportsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tradingButton
            // 
            this.tradingButton.Font = new System.Drawing.Font("Arial", 12.25F);
            this.tradingButton.ForeColor = System.Drawing.Color.Black;
            this.tradingButton.Location = new System.Drawing.Point(12, 62);
            this.tradingButton.Name = "tradingButton";
            this.tradingButton.Size = new System.Drawing.Size(208, 44);
            this.tradingButton.TabIndex = 0;
            this.tradingButton.Text = "режим продажи";
            this.tradingButton.UseVisualStyleBackColor = true;
            this.tradingButton.Click += new System.EventHandler(this.traidingButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Font = new System.Drawing.Font("Arial", 12.25F);
            this.purchaseButton.ForeColor = System.Drawing.Color.Black;
            this.purchaseButton.Location = new System.Drawing.Point(12, 12);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(208, 44);
            this.purchaseButton.TabIndex = 1;
            this.purchaseButton.Text = "режим закупки";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // viewReportsButton
            // 
            this.viewReportsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewReportsButton.ForeColor = System.Drawing.Color.Black;
            this.viewReportsButton.Location = new System.Drawing.Point(12, 112);
            this.viewReportsButton.Name = "viewReportsButton";
            this.viewReportsButton.Size = new System.Drawing.Size(208, 44);
            this.viewReportsButton.TabIndex = 3;
            this.viewReportsButton.Text = "просмотреть отчеты";
            this.viewReportsButton.UseVisualStyleBackColor = true;
            this.viewReportsButton.Click += new System.EventHandler(this.viewReportsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "на счету";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 219);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewReportsButton);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.tradingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tradingButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button viewReportsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

