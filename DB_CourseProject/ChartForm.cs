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
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.Employees1". При необходимости она может быть перемещена или удалена.
            this.Employees1TableAdapter.Fill(this.ComputerFirmDataSet.Employees1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.SalesTableAdapter.Fill(this.ComputerFirmDataSet.Sales);
            SalesBindingSource.DataSource = ComputerFirmDataSet.Sales.ToList();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", SalesBindingSource.DataSource));

            reportViewer1.RefreshReport();
        }
    }
}
