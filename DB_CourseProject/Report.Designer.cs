namespace DB_CourseProject
{
    partial class Report
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
            this.ReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComputerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.SalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SalesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.SalesTableAdapter();
            this.ReportViewTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.ReportViewTableAdapter();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTO = new System.Windows.Forms.DateTimePicker();
            this.buttonBuildReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewBindingSource
            // 
            this.ReportViewBindingSource.DataMember = "ReportView";
            this.ReportViewBindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // ComputerFirmDataSet
            // 
            this.ComputerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.ComputerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesBindingSource
            // 
            this.SalesBindingSource.DataMember = "Sales";
            this.SalesBindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DB_CourseProject.GenReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 136);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(765, 306);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalesTableAdapter
            // 
            this.SalesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewTableAdapter
            // 
            this.ReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(57, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTO
            // 
            this.dateTimePickerTO.Location = new System.Drawing.Point(334, 12);
            this.dateTimePickerTO.Name = "dateTimePickerTO";
            this.dateTimePickerTO.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTO.TabIndex = 2;
            // 
            // buttonBuildReport
            // 
            this.buttonBuildReport.Location = new System.Drawing.Point(634, 59);
            this.buttonBuildReport.Name = "buttonBuildReport";
            this.buttonBuildReport.Size = new System.Drawing.Size(111, 36);
            this.buttonBuildReport.TabIndex = 3;
            this.buttonBuildReport.Text = "Построить";
            this.buttonBuildReport.UseVisualStyleBackColor = true;
            this.buttonBuildReport.Click += new System.EventHandler(this.buttonBuildReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ПО";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuildReport);
            this.Controls.Add(this.dateTimePickerTO);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesBindingSource;
        private ComputerFirmDataSet ComputerFirmDataSet;
        private ComputerFirmDataSetTableAdapters.SalesTableAdapter SalesTableAdapter;
        private System.Windows.Forms.BindingSource ReportViewBindingSource;
        private ComputerFirmDataSetTableAdapters.ReportViewTableAdapter ReportViewTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTO;
        private System.Windows.Forms.Button buttonBuildReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}