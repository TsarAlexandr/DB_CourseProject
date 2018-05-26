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
        DataRowView current;
        public Form1(DataRowView _current)
        {
            InitializeComponent();
            current = _current;
        }

        //private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.employees1BindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.computerFirmDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.computerFirmDataSet.Sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Employees1". При необходимости она может быть перемещена или удалена.
            this.employees1TableAdapter.Fill(this.computerFirmDataSet.Employees1);
            //employees1BindingSource.DataSource = computerFirmDataSet.Employees1.Where(x => x.empId != 0).ToList();
            while (true)
            {
                var cur = (DataRowView)this.employees1BindingSource.Current;
                if (cur["empId"].ToString() == current["empId"].ToString())
                    break;
                this.employees1BindingSource.MoveNext();
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

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            employees1BindingSource.MoveFirst();
        }

        private void buttonPrevios_Click(object sender, EventArgs e)
        {
            employees1BindingSource.MovePrevious();

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            employees1BindingSource.MoveNext();
            

        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            employees1BindingSource.MoveLast();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           
            employees1BindingSource.RemoveCurrent();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            employees1BindingSource.AddNew();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employees1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);
            var emp = this.Owner as Employees;
            var adapter = emp.getAdapter();
            var dataset = emp.getDataSet();
            adapter.Update(dataset.Employees1);
            adapter.Fill(dataset.Employees1);
            MessageBox.Show("Изменения сохранены!");
        }

        private void buttonAddPosition_Click(object sender, EventArgs e)
        {
            AddPositionForm apf = new AddPositionForm();
            apf.Owner = this;
            apf.ShowDialog();
        }
    }
}
