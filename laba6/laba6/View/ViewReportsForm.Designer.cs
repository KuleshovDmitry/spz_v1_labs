namespace laba6
{
    partial class ViewReportsForm
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
            this.slectDayUpDown = new System.Windows.Forms.NumericUpDown();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.currentAmountTextBox = new System.Windows.Forms.TextBox();
            this.numberBuyersTextBox = new System.Windows.Forms.TextBox();
            this.день = new System.Windows.Forms.Label();
            this.покупателей = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slectDayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // slectDayUpDown
            // 
            this.slectDayUpDown.Location = new System.Drawing.Point(94, 21);
            this.slectDayUpDown.Name = "slectDayUpDown";
            this.slectDayUpDown.Size = new System.Drawing.Size(100, 20);
            this.slectDayUpDown.TabIndex = 0;
            this.slectDayUpDown.ValueChanged += new System.EventHandler(this.slectDayUpDown_ValueChanged);
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.Location = new System.Drawing.Point(12, 108);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(416, 121);
            this.productsListBox.TabIndex = 1;
            // 
            // currentAmountTextBox
            // 
            this.currentAmountTextBox.Location = new System.Drawing.Point(94, 82);
            this.currentAmountTextBox.Name = "currentAmountTextBox";
            this.currentAmountTextBox.ReadOnly = true;
            this.currentAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentAmountTextBox.TabIndex = 2;
            // 
            // numberBuyersTextBox
            // 
            this.numberBuyersTextBox.Location = new System.Drawing.Point(94, 56);
            this.numberBuyersTextBox.Name = "numberBuyersTextBox";
            this.numberBuyersTextBox.ReadOnly = true;
            this.numberBuyersTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberBuyersTextBox.TabIndex = 3;
            // 
            // день
            // 
            this.день.AutoSize = true;
            this.день.Location = new System.Drawing.Point(8, 21);
            this.день.Name = "день";
            this.день.Size = new System.Drawing.Size(31, 13);
            this.день.TabIndex = 4;
            this.день.Text = "день";
            // 
            // покупателей
            // 
            this.покупателей.AutoSize = true;
            this.покупателей.Location = new System.Drawing.Point(8, 56);
            this.покупателей.Name = "покупателей";
            this.покупателей.Size = new System.Drawing.Size(71, 13);
            this.покупателей.TabIndex = 5;
            this.покупателей.Text = "покупателей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "текущий доход";
            // 
            // ViewReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 247);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.покупателей);
            this.Controls.Add(this.день);
            this.Controls.Add(this.numberBuyersTextBox);
            this.Controls.Add(this.currentAmountTextBox);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.slectDayUpDown);
            this.Name = "ViewReportsForm";
            this.Text = "ViewReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.slectDayUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown slectDayUpDown;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.TextBox currentAmountTextBox;
        private System.Windows.Forms.TextBox numberBuyersTextBox;
        private System.Windows.Forms.Label день;
        private System.Windows.Forms.Label покупателей;
        private System.Windows.Forms.Label label3;
    }
}