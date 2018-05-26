namespace DB_CourseProject
{
    partial class GeneralReport
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
            this.GeneralReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComputerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.ReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportViewTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.ReportViewTableAdapter();
            this.GeneralReportViewTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.GeneralReportViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneralReportViewBindingSource
            // 
            this.GeneralReportViewBindingSource.DataMember = "GeneralReportView";
            this.GeneralReportViewBindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // ComputerFirmDataSet
            // 
            this.ComputerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.ComputerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportViewBindingSource
            // 
            this.ReportViewBindingSource.DataMember = "ReportView";
            this.ReportViewBindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GeneralReportViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DB_CourseProject.Goods_SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 72);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(529, 295);
            this.reportViewer1.TabIndex = 1;
            // 
            // ReportViewTableAdapter
            // 
            this.ReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralReportViewTableAdapter
            // 
            this.GeneralReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 455);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GeneralReport";
            this.Text = "GeneralReport";
            this.Load += new System.EventHandler(this.GeneralReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeneralReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportViewBindingSource;
        private ComputerFirmDataSet ComputerFirmDataSet;
        private ComputerFirmDataSetTableAdapters.ReportViewTableAdapter ReportViewTableAdapter;
        private System.Windows.Forms.BindingSource GeneralReportViewBindingSource;
        private ComputerFirmDataSetTableAdapters.GeneralReportViewTableAdapter GeneralReportViewTableAdapter;
    }
}