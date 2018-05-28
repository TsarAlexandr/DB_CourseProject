namespace DB_CourseProject
{
    partial class AddItemForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.computerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.GoodsTableAdapter();
            this.tableAdapterManager = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager();
            this.devicesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.DevicesTableAdapter();
            this.typesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TypesTableAdapter();
            this.goodsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasketTableAdapter = null;
            this.tableAdapterManager.DevicesTableAdapter = this.devicesTableAdapter;
            this.tableAdapterManager.Employees1TableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = this.goodsTableAdapter;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.TypesTableAdapter = this.typesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // goodsDataGridView
            // 
            this.goodsDataGridView.AutoGenerateColumns = false;
            this.goodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.goodsDataGridView.DataSource = this.goodsBindingSource;
            this.goodsDataGridView.Location = new System.Drawing.Point(9, 146);
            this.goodsDataGridView.Name = "goodsDataGridView";
            this.goodsDataGridView.ReadOnly = true;
            this.goodsDataGridView.Size = new System.Drawing.Size(268, 257);
            this.goodsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена за шт.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.DataSource = this.devicesBindingSource;
            this.comboBoxDevices.DisplayMember = "devName";
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(9, 119);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDevices.TabIndex = 2;
            this.comboBoxDevices.ValueMember = "devId";
            this.comboBoxDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevices_SelectedIndexChanged);
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            this.devicesBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.DataSource = this.typesBindingSource;
            this.comboBoxTypes.DisplayMember = "type";
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(156, 119);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypes.TabIndex = 3;
            this.comboBoxTypes.ValueMember = "typeId";
            this.comboBoxTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypes_SelectedIndexChanged);
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "Types";
            this.typesBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(469, 146);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(156, 104);
            this.buttonAddItem.TabIndex = 4;
            this.buttonAddItem.Text = "Добавить";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(343, 179);
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericQuantity.TabIndex = 5;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Устройство";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(442, 22);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(73, 48);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поиск по названию";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.comboBoxTypes);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.goodsDataGridView);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private ComputerFirmDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private ComputerFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ComputerFirmDataSetTableAdapters.DevicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.DataGridView goodsDataGridView;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private ComputerFirmDataSetTableAdapters.TypesTableAdapter typesTableAdapter;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}