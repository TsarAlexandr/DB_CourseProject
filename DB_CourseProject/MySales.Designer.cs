namespace DB_CourseProject
{
    partial class MySales
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
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.SalesTableAdapter();
            this.tableAdapterManager = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasketTableAdapter = null;
            this.tableAdapterManager.DevicesTableAdapter = null;
            this.tableAdapterManager.Employees1TableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.TypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.salesDataGridView.DataSource = this.salesBindingSource;
            this.salesDataGridView.Location = new System.Drawing.Point(12, 49);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.Size = new System.Drawing.Size(546, 266);
            this.salesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "saleId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИД продажи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "orederId";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИД заказа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // MySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 424);
            this.Controls.Add(this.salesDataGridView);
            this.Name = "MySales";
            this.Text = "MySales";
            this.Load += new System.EventHandler(this.MySales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private ComputerFirmDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private ComputerFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}