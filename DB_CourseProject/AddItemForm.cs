using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_CourseProject
{
    public partial class AddItemForm : Form
    {
       
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);

        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Types". При необходимости она может быть перемещена или удалена.
            this.typesTableAdapter.Fill(this.computerFirmDataSet.Types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Devices". При необходимости она может быть перемещена или удалена.
            this.devicesTableAdapter.Fill(this.computerFirmDataSet.Devices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.computerFirmDataSet.Goods);

        }

        private void comboBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = "";
            if (comboBoxTypes.SelectedItem != null)
                filter += "typeId=" + comboBoxTypes.SelectedValue + " and ";
            filter += "tDeviceId=" + comboBoxDevices.SelectedValue;
            goodsBindingSource.Filter = filter;
            goodsTableAdapter.Fill(computerFirmDataSet.Goods);
            
        }

        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = "";
            if (comboBoxDevices.SelectedItem != null)
                filter += "tDeviceId=" + comboBoxDevices.SelectedValue + " and ";
            filter += "typeId=" + comboBoxTypes.SelectedValue;
            goodsBindingSource.Filter = filter;
            goodsTableAdapter.Fill(computerFirmDataSet.Goods);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var filter = "name LIKE '%" + textBox1.Text + "%'";
            goodsBindingSource.Filter = filter;
            goodsTableAdapter.Fill(computerFirmDataSet.Goods);
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            DataRowView current = (DataRowView)this.goodsBindingSource.Current;
            var par = this.Owner as Order;
            var grid = par.getGrid();
            var ID = current["goodsId"].ToString();
            var Name = current["name"].ToString();
            var Price = Decimal.Parse(current["price"].ToString());
            var Count = Int32.Parse(numericQuantity.Value.ToString());
            var Cost = Price * Count;
            grid.Rows.Add(ID, Name, Price, Count, Cost);
            par.getTotalCost();
            this.Close();
        }
    }
}
