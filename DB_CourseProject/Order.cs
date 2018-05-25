using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CourseProject
{
    public partial class Order : Form
    {
        List<int> baskets = new List<int>();
        int empId;
        static string connectionString = "Data Source=DELLTSAR\\MSSQLSERVER1;Initial Catalog=ComputerFirm;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Order(int empId)
        {
            InitializeComponent();
            this.empId = empId;
        }

        private int addBasket(string goodID, string count)
        {
            var command = new SqlCommand("AddItem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@GoodsID", SqlDbType.Int));
            command.Parameters["@GoodsID"].Value = Int32.Parse(goodID);
            command.Parameters.Add(new SqlParameter("@Count", SqlDbType.Int, 4));
            command.Parameters["@Count"].Value = Int32.Parse(count);
            int orderID = -10;

            command.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int, 4));
            command.Parameters["@OrderID"].Direction = ParameterDirection.Output;
            con.Open();
            try
            {
                int numAff = command.ExecuteNonQuery();
                orderID = (int)command.Parameters["@OrderID"].Value;

            }
            finally
            {
                con.Close();
            }
            return orderID;
        }

        private void addOrder(int orderID, string price)
        {
            var command = new SqlCommand("AddOrder", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int, 4));
            command.Parameters["@OrderID"].Value = orderID;
            command.Parameters.Add(new SqlParameter("@OrderPrice", SqlDbType.Decimal, 8));
            command.Parameters["@OrderPrice"].Value = Decimal.Parse(price);
            command.Parameters.Add(new SqlParameter("@EmpId", SqlDbType.Int, 4));
            command.Parameters["@EmpId"].Value = empId;

            con.Open();
            try
            {
                int numAff = command.ExecuteNonQuery();                
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonGetOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
            {
                var ID = dataGridView1.Rows[i].Cells["ItemId"].Value.ToString();
                var Quan = dataGridView1.Rows[i].Cells["Quantity"].Value.ToString();
                var Price = dataGridView1.Rows[i].Cells["Price"].Value.ToString();
                var orderId = addBasket(ID, Quan);
                if (orderId != -10)
                    addOrder(orderId, Price);
            }
            MessageBox.Show("Order Passed!");
            

        }

        public void getTotalCost()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
            {
                sum += Decimal.Parse(dataGridView1.Rows[i].Cells["Price"].Value.ToString());
            }

            labelTotal.Text = sum.ToString();
        }

        public DataGridView getGrid()
        {
            return this.dataGridView1;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            AddItemForm aif = new AddItemForm();
            aif.Owner = this;
            aif.ShowDialog();
        }

        private void buttonRemoveCurrent_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                dataGridView1.Rows.Remove(row);
            getTotalCost();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Employees1". При необходимости она может быть перемещена или удалена.
            this.employees1TableAdapter.Fill(this.computerFirmDataSet.Employees1);
            var emp = computerFirmDataSet.Employees1.FindByempId(empId);
            labelName.Text = emp["surname"].ToString() + " " + emp["name"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            s.ShowDialog();
        }
    }
}
