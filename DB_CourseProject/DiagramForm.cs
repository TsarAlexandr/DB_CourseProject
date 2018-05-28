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
    public partial class DiagramForm : Form
    {
        public DiagramForm()
        {
            InitializeComponent();
        }

        private void DiagramForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.TypeView". При необходимости она может быть перемещена или удалена.
            this.typeViewTableAdapter.Fill(this.computerFirmDataSet.TypeView);
            typeViewBindingSource.DataSource = computerFirmDataSet.TypeView.ToList();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", typeViewBindingSource.DataSource));

            reportViewer1.RefreshReport();

        }
    }
}
