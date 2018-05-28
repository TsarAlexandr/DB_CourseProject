namespace DB_CourseProject
{
    partial class DiagramForm
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
            this.typeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeViewTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TypeViewTableAdapter();
            this.tableAdapterManager = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeViewBindingSource
            // 
            this.typeViewBindingSource.DataMember = "TypeView";
            this.typeViewBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // typeViewTableAdapter
            // 
            this.typeViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasketTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DevicesTableAdapter = null;
            this.tableAdapterManager.Employees1TableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.TypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DB_CourseProject.TypePercent.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(615, 430);
            this.reportViewer1.TabIndex = 3;
            // 
            // DiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 430);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DiagramForm";
            this.Text = "DiagramForm";
            this.Load += new System.EventHandler(this.DiagramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource typeViewBindingSource;
        private ComputerFirmDataSetTableAdapters.TypeViewTableAdapter typeViewTableAdapter;
        private ComputerFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}