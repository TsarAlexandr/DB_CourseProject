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
    public partial class AddEmployee : Form
    {
        Employees emp;
        


        public AddEmployee()
        {
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            emp = this.Owner as Employees;
            var adapter = emp.getAdapter();
            var dataset = emp.getDataSet();

            var EmployeeTable = dataset.Employees1;
            DataRow row = EmployeeTable.NewRow();
            try
            {
                row["surname"] = textBox1.Text;
                row["name"] = textBox2.Text;
                row["patronymic"] = textBox3.Text;
                row["salary"] = Decimal.Parse(textBox4.Text);
                row["posId"] = Int32.Parse(comboBox1.SelectedValue.ToString());
            
                EmployeeTable.Rows.Add(row);
                adapter.Update(EmployeeTable);

                adapter.Fill(EmployeeTable);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ввыедены некорректные данные!!");
            }
        }
        public ComputerFirmDataSetTableAdapters.PositionsTableAdapter getPosAdapter()
        {
            return this.positionsTableAdapter;
        }
        
        public ComputerFirmDataSet getDataSet()
        {
            return this.computerFirmDataSet;
        }


        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.computerFirmDataSet.Positions);
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddPositionForm apf = new AddPositionForm();
            apf.Owner = this;
            apf.ShowDialog();
        }
    }
}
