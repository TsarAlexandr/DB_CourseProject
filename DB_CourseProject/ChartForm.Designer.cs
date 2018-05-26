namespace DB_CourseProject
{
    partial class ChartForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ComputerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.Employees1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Employees1TableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.Employees1TableAdapter();
            this.ReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.ReportViewTableAdapter();
            this.SalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.SalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employees1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DB_CourseProject.Chart.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(565, 387);
            this.reportViewer1.TabIndex = 2;
            // 
            // ComputerFirmDataSet
            // 
            this.ComputerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.ComputerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Employees1BindingSource
            // 
            this.Employees1BindingSource.DataMember = "Employees1";
            this.Employees1BindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // Employees1TableAdapter
            // 
            this.Employees1TableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewBindingSource
            // 
            this.ReportViewBindingSource.DataMember = "ReportView";
            this.ReportViewBindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // ReportViewTableAdapter
            // 
            this.ReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // SalesBindingSource
            // 
            this.SalesBindingSource.DataMember = "Sales";
            this.SalesBindingSource.DataSource = this.ComputerFirmDataSet;
            // 
            // SalesTableAdapter
            // 
            this.SalesTableAdapter.ClearBeforeFill = true;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 387);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComputerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employees1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Employees1BindingSource;
        private ComputerFirmDataSet ComputerFirmDataSet;
        private ComputerFirmDataSetTableAdapters.Employees1TableAdapter Employees1TableAdapter;
        private System.Windows.Forms.BindingSource ReportViewBindingSource;
        private ComputerFirmDataSetTableAdapters.ReportViewTableAdapter ReportViewTableAdapter;
        private System.Windows.Forms.BindingSource SalesBindingSource;
        private ComputerFirmDataSetTableAdapters.SalesTableAdapter SalesTableAdapter;
    }
}