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
            this.computerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.employees1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees1TableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.Employees1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).BeginInit();
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DB_CourseProject.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // CertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 404);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CertForm";
            this.Text = "CertForm";
            this.Load += new System.EventHandler(this.CertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource employees1BindingSource;
        private ComputerFirmDataSetTableAdapters.Employees1TableAdapter employees1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}