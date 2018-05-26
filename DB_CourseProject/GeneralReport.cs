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
    public partial class GeneralReport : Form
    {
        public GeneralReport()
        {
            InitializeComponent();
        }

        private void GeneralReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.GeneralReportView". При необходимости она может быть перемещена или удалена.
            this.GeneralReportViewTableAdapter.Fill(this.ComputerFirmDataSet.GeneralReportView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.ReportView". При необходимости она может быть перемещена или удалена.

            GeneralReportViewBindingSource.DataSource = ComputerFirmDataSet.GeneralReportView.ToList();
            reportViewer1.RefreshReport();
        }
    }
}
