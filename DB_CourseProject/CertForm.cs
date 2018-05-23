using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CourseProject
{
    public partial class CertForm : Form
    {
        Employees emp;
        public CertForm()
        {
            InitializeComponent();
        }

        private void CertForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Employees1". При необходимости она может быть перемещена или удалена.
            //this.employees1TableAdapter.Fill(this.computerFirmDataSet.Employees1);
            emp = this.Owner as Employees;
            employees1BindingSource.DataSource = emp.getBSource().Current;

            //string FIO = current["surname"].ToString() + " " + current["name"].ToString() + " " + current["patronymic"].ToString();
            //ReportParameter pFIO = new ReportParameter("pFIO", FIO);
            //reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pFIO });

            //var reportData = new ReportDataSource("DataSet1", employees1BindingSource);
            //reportViewer1.LocalReport.DataSources.Add(reportData); 
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
