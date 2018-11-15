namespace laba5
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
            this.components = new System.ComponentModel.Container();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.addCortegeBt = new System.Windows.Forms.Button();
            this.deleteDisciplineButton = new System.Windows.Forms.Button();
            this.deleteLecturerButton = new System.Windows.Forms.Button();
            this.sortByLecturerButton = new System.Windows.Forms.Button();
            this.sortByDsciplineButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serializeButton = new System.Windows.Forms.Button();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deserializeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(0, 1);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.Size = new System.Drawing.Size(243, 213);
            this.mainDataGridView.TabIndex = 0;
            this.mainDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellContentDoubleClick);
            // 
            // addCortegeBt
            // 
            this.addCortegeBt.Location = new System.Drawing.Point(249, 12);
            this.addCortegeBt.Name = "addCortegeBt";
            this.addCortegeBt.Size = new System.Drawing.Size(185, 23);
            this.addCortegeBt.TabIndex = 1;
            this.addCortegeBt.Text = "Добавить кортеж";
            this.addCortegeBt.UseVisualStyleBackColor = true;
            this.addCortegeBt.Click += new System.EventHandler(this.addCortegeBt_Click);
            // 
            // deleteDisciplineButton
            // 
            this.deleteDisciplineButton.Location = new System.Drawing.Point(249, 41);
            this.deleteDisciplineButton.Name = "deleteDisciplineButton";
            this.deleteDisciplineButton.Size = new System.Drawing.Size(185, 23);
            this.deleteDisciplineButton.TabIndex = 2;
            this.deleteDisciplineButton.Text = "Убрать предмет";
            this.deleteDisciplineButton.UseVisualStyleBackColor = true;
            this.deleteDisciplineButton.Click += new System.EventHandler(this.deleteDisciplineButton_Click);
            // 
            // deleteLecturerButton
            // 
            this.deleteLecturerButton.Location = new System.Drawing.Point(249, 70);
            this.deleteLecturerButton.Name = "deleteLecturerButton";
            this.deleteLecturerButton.Size = new System.Drawing.Size(185, 23);
            this.deleteLecturerButton.TabIndex = 3;
            this.deleteLecturerButton.Text = "Убрать преподавателя";
            this.deleteLecturerButton.UseVisualStyleBackColor = true;
            this.deleteLecturerButton.Click += new System.EventHandler(this.deleteLecturerButton_Click);
            // 
            // sortByLecturerButton
            // 
            this.sortByLecturerButton.Location = new System.Drawing.Point(249, 99);
            this.sortByLecturerButton.Name = "sortByLecturerButton";
            this.sortByLecturerButton.Size = new System.Drawing.Size(185, 23);
            this.sortByLecturerButton.TabIndex = 4;
            this.sortByLecturerButton.Text = "Сортировать по преподавателям";
            this.sortByLecturerButton.UseVisualStyleBackColor = true;
            this.sortByLecturerButton.Click += new System.EventHandler(this.sortByLecturerButton_Click);
            // 
            // sortByDsciplineButton
            // 
            this.sortByDsciplineButton.Location = new System.Drawing.Point(249, 128);
            this.sortByDsciplineButton.Name = "sortByDsciplineButton";
            this.sortByDsciplineButton.Size = new System.Drawing.Size(185, 23);
            this.sortByDsciplineButton.TabIndex = 5;
            this.sortByDsciplineButton.Text = "Сортировать по дисциплине";
            this.sortByDsciplineButton.UseVisualStyleBackColor = true;
            this.sortByDsciplineButton.Click += new System.EventHandler(this.sortByDsciplineButton_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // serializeButton
            // 
            this.serializeButton.Location = new System.Drawing.Point(249, 157);
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(185, 23);
            this.serializeButton.TabIndex = 6;
            this.serializeButton.Text = "Сериализация";
            this.serializeButton.UseVisualStyleBackColor = true;
            this.serializeButton.Click += new System.EventHandler(this.serializeButton_Click);
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(laba5.MainForm);
            // 
            // deserializeButton
            // 
            this.deserializeButton.Location = new System.Drawing.Point(249, 186);
            this.deserializeButton.Name = "deserializeButton";
            this.deserializeButton.Size = new System.Drawing.Size(185, 23);
            this.deserializeButton.TabIndex = 7;
            this.deserializeButton.Text = "Десериализация";
            this.deserializeButton.UseVisualStyleBackColor = true;
            this.deserializeButton.Click += new System.EventHandler(this.deserializeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 226);
            this.Controls.Add(this.deserializeButton);
            this.Controls.Add(this.serializeButton);
            this.Controls.Add(this.sortByDsciplineButton);
            this.Controls.Add(this.sortByLecturerButton);
            this.Controls.Add(this.deleteLecturerButton);
            this.Controls.Add(this.deleteDisciplineButton);
            this.Controls.Add(this.addCortegeBt);
            this.Controls.Add(this.mainDataGridView);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Button addCortegeBt;
        private System.Windows.Forms.Button deleteDisciplineButton;
        private System.Windows.Forms.Button deleteLecturerButton;
        private System.Windows.Forms.Button sortByLecturerButton;
        private System.Windows.Forms.Button sortByDsciplineButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button serializeButton;
        private System.Windows.Forms.Button deserializeButton;
    }
}

