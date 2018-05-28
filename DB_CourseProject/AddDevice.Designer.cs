namespace DB_CourseProject
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
            this.components = new System.ComponentModel.Container();
            this.computerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devicesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.DevicesTableAdapter();
            this.tableAdapterManager = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager();
            this.devicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            this.devicesBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasketTableAdapter = null;
            this.tableAdapterManager.DevicesTableAdapter = this.devicesTableAdapter;
            this.tableAdapterManager.Employees1TableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.TypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // devicesDataGridView
            // 
            this.devicesDataGridView.AutoGenerateColumns = false;
            this.devicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.devicesDataGridView.DataSource = this.devicesBindingSource;
            this.devicesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.devicesDataGridView.Name = "devicesDataGridView";
            this.devicesDataGridView.Size = new System.Drawing.Size(244, 80);
            this.devicesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "devId";
            this.dataGridViewTextBoxColumn1.HeaderText = "devId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "devName";
            this.dataGridViewTextBoxColumn2.HeaderText = "devName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(281, 28);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 47);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Соханить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 306);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.devicesDataGridView);
            this.Name = "AddDevice";
            this.Text = "AddDevice";
            this.Load += new System.EventHandler(this.AddDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private ComputerFirmDataSetTableAdapters.DevicesTableAdapter devicesTableAdapter;
        private ComputerFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView devicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonSave;
    }
}