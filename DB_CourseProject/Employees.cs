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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void employees1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employees1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.computerFirmDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Employees1". При необходимости она может быть перемещена или удалена.
            this.employees1TableAdapter.Fill(this.computerFirmDataSet.Employees1);

        }

        public BindingSource getBSource()
        {
            return this.employees1BindingSource;
        }
        public ComputerFirmDataSetTableAdapters.PositionsTableAdapter getPosAdapter()
        {
            return this.positionsTableAdapter;
        }
        public ComputerFirmDataSetTableAdapters.Employees1TableAdapter getAdapter()
        {
            return this.employees1TableAdapter;
        }

        public ComputerFirmDataSet getDataSet()
        {
            return this.computerFirmDataSet;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1((DataRowView)this.employees1BindingSource.Current);
            f1.Owner = this;
            f1.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.employees1BindingSource.RemoveCurrent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.Owner = this;
            ae.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.employees1BindingSource.Filter = "posId=" + comboBox1.SelectedValue;
            this.employees1TableAdapter.Fill(this.computerFirmDataSet.Employees1);
        }

        private void buttonCertificate_Click(object sender, EventArgs e)
        {
            CertForm cert = new CertForm();
            cert.Owner = this;
            cert.ShowDialog();
        }
    }
}
