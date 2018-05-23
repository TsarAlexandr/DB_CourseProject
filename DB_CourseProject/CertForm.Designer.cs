namespace DB_CourseProject
{
    partial class CertForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.computerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.employees1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees1TableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.Employees1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.SalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).BeginInit();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.employees1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DB_CourseProject.Certificate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(705, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalesBindingSource
            // 
            this.SalesBindingSource.DataMember = "Sales";
            this.SalesBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // SalesTableAdapter
            // 
            this.SalesTableAdapter.ClearBeforeFill = true;
            // 
            // CertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 404);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CertForm";
            this.Text = "CertForm";
            this.Load += new System.EventHandler(this.CertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource employees1BindingSource;
        private ComputerFirmDataSetTableAdapters.Employees1TableAdapter employees1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesBindingSource;
        private ComputerFirmDataSetTableAdapters.SalesTableAdapter SalesTableAdapter;
    }
}