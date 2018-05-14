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
        Form1 f1;
        DataRowView current;


        public AddEmployee()
        {
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        { 
            
            var adapter = f1.getAdapter();
            var dataset = f1.getDataSet();

            var EmployeeTable = dataset.Employees1;
            DataRow row = EmployeeTable.NewRow();
            row["surname"] = textBox1.Text;
            row["name"] = textBox2.Text;
            row["patronymic"] = textBox3.Text;
            row["salary"] = Decimal.Parse(textBox4.Text);
            EmployeeTable.Rows.Add(row);
            adapter.Update(EmployeeTable);
            adapter.Fill(EmployeeTable);
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var bSource = f1.getBSource();            
            bSource.RemoveCurrent();
            this.Close();

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            f1 = this.Owner as Form1;
            current = (DataRowView)f1.getBSource().Current;
            textBox1.Text = current["surname"].ToString();
            textBox2.Text = current["name"].ToString();
            textBox3.Text = current["patronymic"].ToString();
            textBox4.Text = current["salary"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var adapter = f1.getAdapter();
            var dataset = f1.getDataSet();
            var EmployeeTable = dataset.Employees1;
            var row = EmployeeTable.First(x => x.empId == Int32.Parse(current["empId"].ToString()));
            row["surname"] = textBox1.Text;
            row["name"] = textBox2.Text;
            row["patronymic"] = textBox3.Text;
            row["salary"] = Decimal.Parse(textBox4.Text);
            adapter.Update(EmployeeTable);
            this.Close();
        }
    }
}
