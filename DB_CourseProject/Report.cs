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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.ReportView". При необходимости она может быть перемещена или удалена.
            this.ReportViewTableAdapter.Fill(this.ComputerFirmDataSet.ReportView);
            ReportViewBindingSource.DataSource = ComputerFirmDataSet.ReportView.ToList();
            reportViewer1.RefreshReport();

        }

        
        private void buttonBuildReport_Click(object sender, EventArgs e)
        {
            
            var source = ComputerFirmDataSet.ReportView.Where(x => (x.date >= dateTimePickerFrom.Value.Date && x.date <= dateTimePickerTO.Value));
            ReportViewBindingSource.DataSource = source.ToList();
            this.reportViewer1.RefreshReport();
        }
    }
}
