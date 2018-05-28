namespace DB_CourseProject
{
    partial class AddType
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
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TypesTableAdapter();
            this.tableAdapterManager = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager();
            this.typesDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "Types";
            this.typesBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasketTableAdapter = null;
            this.tableAdapterManager.DevicesTableAdapter = null;
            this.tableAdapterManager.Employees1TableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.TypesTableAdapter = this.typesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // typesDataGridView
            // 
            this.typesDataGridView.AutoGenerateColumns = false;
            this.typesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.typesDataGridView.DataSource = this.typesBindingSource;
            this.typesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.typesDataGridView.Name = "typesDataGridView";
            this.typesDataGridView.Size = new System.Drawing.Size(300, 220);
            this.typesDataGridView.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(363, 179);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 69);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "typeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 338);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.typesDataGridView);
            this.Name = "AddType";
            this.Text = "AddType";
            this.Load += new System.EventHandler(this.AddType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private ComputerFirmDataSetTableAdapters.TypesTableAdapter typesTableAdapter;
        private ComputerFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView typesDataGridView;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}