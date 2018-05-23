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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ComputerFirmDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.SalesTableAdapter.Fill(this.ComputerFirmDataSet.Sales);
            SalesBindingSource.DataSource = ComputerFirmDataSet.Sales.ToList();
            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            SalesBindingSource.DataSource = ComputerFirmDataSet.Sales.ToList();
            this.reportViewer1.RefreshReport();
        }
    }
}
