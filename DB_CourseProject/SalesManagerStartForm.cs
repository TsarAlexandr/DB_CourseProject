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
    public partial class SalesManagerStartForm : Form
    {
        int empId;
        public SalesManagerStartForm(int empId)
        {
            InitializeComponent();
            this.empId = empId;
        }

        private void buttonMySales_Click(object sender, EventArgs e)
        {
            MySales ms = new MySales(empId);
            ms.ShowDialog();
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            Order ord = new Order(empId);
            ord.ShowDialog();
        }
    }
}
