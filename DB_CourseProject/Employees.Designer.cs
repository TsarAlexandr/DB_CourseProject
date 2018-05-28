namespace DB_CourseProject
{
    partial class Employees
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
            this.components = new System.ComponentModel.Container();
            this.computerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.employees1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees1TableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.Employees1TableAdapter();
            this.tableAdapterManager = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager();
            this.positionsTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.PositionsTableAdapter();
            this.employees1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCertificate = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employees1BindingSource
            // 
            this.employees1BindingSource.DataMember = "Employees1";
            this.employees1BindingSource.DataSource = this.computerFirmDataSet;
            // 
            // employees1TableAdapter
            // 
            this.employees1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasketTableAdapter = null;
            this.tableAdapterManager.DevicesTableAdapter = null;
            this.tableAdapterManager.Employees1TableAdapter = this.employees1TableAdapter;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = this.positionsTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.TypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // employees1DataGridView
            // 
            this.employees1DataGridView.AutoGenerateColumns = false;
            this.employees1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.employees1DataGridView.DataSource = this.employees1BindingSource;
            this.employees1DataGridView.Location = new System.Drawing.Point(12, 69);
            this.employees1DataGridView.Name = "employees1DataGridView";
            this.employees1DataGridView.ReadOnly = true;
            this.employees1DataGridView.Size = new System.Drawing.Size(380, 249);
            this.employees1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.positionsBindingSource;
            this.comboBox1.DisplayMember = "posName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "posId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(444, 78);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 34);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(444, 136);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 34);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(428, 195);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(128, 36);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Информация/Правка";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCertificate
            // 
            this.buttonCertificate.Location = new System.Drawing.Point(447, 276);
            this.buttonCertificate.Name = "buttonCertificate";
            this.buttonCertificate.Size = new System.Drawing.Size(64, 41);
            this.buttonCertificate.TabIndex = 6;
            this.buttonCertificate.Text = "Справка";
            this.buttonCertificate.UseVisualStyleBackColor = true;
            this.buttonCertificate.Click += new System.EventHandler(this.buttonCertificate_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(213, 28);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(75, 23);
            this.buttonAll.TabIndex = 7;
            this.buttonAll.Text = "Все";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Должности";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonCertificate);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.employees1DataGridView);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource employees1BindingSource;
        private ComputerFirmDataSetTableAdapters.Employees1TableAdapter employees1TableAdapter;
        private ComputerFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employees1DataGridView;
        private ComputerFirmDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCertificate;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
    }
}