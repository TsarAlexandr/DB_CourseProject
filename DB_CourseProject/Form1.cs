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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.computerFirmDataSet.Employees);

        }
        
        public BindingSource  getBSource()
        {
            return this.employeesBindingSource;
        }
        public ComputerFirmDataSetTableAdapters.EmployeesTableAdapter getAdapter()
        {
            return this.employeesTableAdapter;
        }

        public ComputerFirmDataSet getDataSet()
        {
            return this.computerFirmDataSet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee f2 = new AddEmployee();
            f2.Owner = this;
            f2.ShowDialog();
        }
    }
}
