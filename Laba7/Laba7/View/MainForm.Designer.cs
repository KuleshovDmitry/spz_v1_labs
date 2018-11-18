//using Laba7.Model;

namespace Laba7
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
            this.createLecturerButton = new System.Windows.Forms.Button();
            this.cortegeDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteCortegeButton = new System.Windows.Forms.Button();
            this.addCortegeButton = new System.Windows.Forms.Button();
            this.deleteDisciplineButton = new System.Windows.Forms.Button();
            this.deleteLectrerButton = new System.Windows.Forms.Button();
            this.addDisciplineButton = new System.Windows.Forms.Button();
            this.lecturerIdTextBox = new System.Windows.Forms.TextBox();
            this.disciplineIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.laba7DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laba7DBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deleteCortegeByIdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cortegeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laba7DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laba7DBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // createLecturerButton
            // 
            this.createLecturerButton.Location = new System.Drawing.Point(12, 214);
            this.createLecturerButton.Name = "createLecturerButton";
            this.createLecturerButton.Size = new System.Drawing.Size(179, 23);
            this.createLecturerButton.TabIndex = 0;
            this.createLecturerButton.Text = "Добавить преподавателя";
            this.createLecturerButton.UseVisualStyleBackColor = true;
            this.createLecturerButton.Click += new System.EventHandler(this.addLecturerButton_Click);
            // 
            // cortegeDataGrid
            // 
            this.cortegeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cortegeDataGrid.Location = new System.Drawing.Point(0, 0);
            this.cortegeDataGrid.Name = "cortegeDataGrid";
            this.cortegeDataGrid.ReadOnly = true;
            this.cortegeDataGrid.Size = new System.Drawing.Size(428, 150);
            this.cortegeDataGrid.TabIndex = 1;
            // 
            // deleteCortegeButton
            // 
            this.deleteCortegeButton.Location = new System.Drawing.Point(236, 156);
            this.deleteCortegeButton.Name = "deleteCortegeButton";
            this.deleteCortegeButton.Size = new System.Drawing.Size(179, 23);
            this.deleteCortegeButton.TabIndex = 2;
            this.deleteCortegeButton.Text = "Убрать выбранные кортежи";
            this.deleteCortegeButton.UseVisualStyleBackColor = true;
            this.deleteCortegeButton.Click += new System.EventHandler(this.deleteCortegeButton_Click);
            // 
            // addCortegeButton
            // 
            this.addCortegeButton.Location = new System.Drawing.Point(12, 156);
            this.addCortegeButton.Name = "addCortegeButton";
            this.addCortegeButton.Size = new System.Drawing.Size(179, 23);
            this.addCortegeButton.TabIndex = 3;
            this.addCortegeButton.Text = "Добавить кортеж";
            this.addCortegeButton.UseVisualStyleBackColor = true;
            this.addCortegeButton.Click += new System.EventHandler(this.addCortegeButton_Click);
            // 
            // deleteDisciplineButton
            // 
            this.deleteDisciplineButton.Location = new System.Drawing.Point(236, 185);
            this.deleteDisciplineButton.Name = "deleteDisciplineButton";
            this.deleteDisciplineButton.Size = new System.Drawing.Size(179, 23);
            this.deleteDisciplineButton.TabIndex = 4;
            this.deleteDisciplineButton.Text = "Убрать предмет";
            this.deleteDisciplineButton.UseVisualStyleBackColor = true;
            this.deleteDisciplineButton.Click += new System.EventHandler(this.removeDisciplineButton_Click);
            // 
            // deleteLectrerButton
            // 
            this.deleteLectrerButton.Location = new System.Drawing.Point(236, 214);
            this.deleteLectrerButton.Name = "deleteLectrerButton";
            this.deleteLectrerButton.Size = new System.Drawing.Size(179, 23);
            this.deleteLectrerButton.TabIndex = 5;
            this.deleteLectrerButton.Text = "Убрать преподавателя";
            this.deleteLectrerButton.UseVisualStyleBackColor = true;
            this.deleteLectrerButton.Click += new System.EventHandler(this.removeLectrrButton_Click);
            // 
            // addDisciplineButton
            // 
            this.addDisciplineButton.Location = new System.Drawing.Point(12, 185);
            this.addDisciplineButton.Name = "addDisciplineButton";
            this.addDisciplineButton.Size = new System.Drawing.Size(179, 23);
            this.addDisciplineButton.TabIndex = 6;
            this.addDisciplineButton.Text = "Добавить предмет";
            this.addDisciplineButton.UseVisualStyleBackColor = true;
            this.addDisciplineButton.Click += new System.EventHandler(this.addDisciplineButton_Click);
            // 
            // lecturerIdTextBox
            // 
            this.lecturerIdTextBox.Location = new System.Drawing.Point(91, 269);
            this.lecturerIdTextBox.Name = "lecturerIdTextBox";
            this.lecturerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.lecturerIdTextBox.TabIndex = 7;
            // 
            // disciplineIdTextBox
            // 
            this.disciplineIdTextBox.Location = new System.Drawing.Point(91, 295);
            this.disciplineIdTextBox.Name = "disciplineIdTextBox";
            this.disciplineIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.disciplineIdTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id лектора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id предмета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Эти поля для удаления лектора/предмета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = " и добавления/удаления кортежа.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Мне искренне лень ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "делать 4 дополнительные формы";
            // 
            // deleteCortegeByIdButton
            // 
            this.deleteCortegeByIdButton.Location = new System.Drawing.Point(12, 240);
            this.deleteCortegeByIdButton.Name = "deleteCortegeByIdButton";
            this.deleteCortegeByIdButton.Size = new System.Drawing.Size(179, 23);
            this.deleteCortegeByIdButton.TabIndex = 15;
            this.deleteCortegeByIdButton.Text = "Убрать кортеж по Id";
            this.deleteCortegeByIdButton.UseVisualStyleBackColor = true;
            this.deleteCortegeByIdButton.Click += new System.EventHandler(this.deleteCortegeByIdButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(429, 324);
            this.Controls.Add(this.deleteCortegeByIdButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disciplineIdTextBox);
            this.Controls.Add(this.lecturerIdTextBox);
            this.Controls.Add(this.addDisciplineButton);
            this.Controls.Add(this.deleteLectrerButton);
            this.Controls.Add(this.deleteDisciplineButton);
            this.Controls.Add(this.addCortegeButton);
            this.Controls.Add(this.deleteCortegeButton);
            this.Controls.Add(this.cortegeDataGrid);
            this.Controls.Add(this.createLecturerButton);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.cortegeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laba7DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laba7DBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       //private Laba7DBDataSet laba7DBDataSet;
        private System.Windows.Forms.BindingSource cortegeBindingSource;
       // private Model.Laba7DBDataSetTableAdapters.CortegeTableAdapter cortegeTableAdapter;
       // private Model.Laba7DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cortegeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cortegeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cortegeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button createLecturerButton;
        private System.Windows.Forms.BindingSource laba7DBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource laba7DBDataSetBindingSource;
        private System.Windows.Forms.DataGridView cortegeDataGrid;
        private System.Windows.Forms.Button deleteCortegeButton;
        private System.Windows.Forms.Button addCortegeButton;
        private System.Windows.Forms.Button deleteDisciplineButton;
        private System.Windows.Forms.Button deleteLectrerButton;
        private System.Windows.Forms.Button addDisciplineButton;
        private System.Windows.Forms.TextBox lecturerIdTextBox;
        private System.Windows.Forms.TextBox disciplineIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteCortegeByIdButton;
    }
}

