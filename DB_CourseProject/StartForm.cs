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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void buttonEmp_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.ShowDialog();
        }

        private void buttonPos_Click(object sender, EventArgs e)
        {
            AddPositionForm apf = new AddPositionForm();
            apf.Owner = this;
            apf.ShowDialog();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            s.ShowDialog();
        }
    }
}
