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
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);

        }

        private void NewItem_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Types". При необходимости она может быть перемещена или удалена.
            this.typesTableAdapter.Fill(this.computerFirmDataSet.Types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Devices". При необходимости она может быть перемещена или удалена.
            this.devicesTableAdapter.Fill(this.computerFirmDataSet.Devices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.computerFirmDataSet.Goods);

        }

        public ComputerFirmDataSetTableAdapters.DevicesTableAdapter getDevAdapter()
        {
            return this.devicesTableAdapter;
        }

        public ComputerFirmDataSetTableAdapters.TypesTableAdapter getTypeAdapter()
        {
            return this.typesTableAdapter;
        }

        public ComputerFirmDataSet getDataSet()
        {
            return this.computerFirmDataSet;
        }

               
        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.MoveNext();
        }

        private void buttonLast_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.MoveLast();
        }

        private void buttonPrevios_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.MovePrevious();
        }

        private void buttonFirst_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.MoveFirst();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            goodsBindingSource.RemoveCurrent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            goodsBindingSource.AddNew();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);
        }

        private void buttonAddDevice_Click(object sender, EventArgs e)
        {
            AddDevice ad = new AddDevice();
            ad.Owner = this;
            ad.ShowDialog();
        }

        private void buttonAddType_Click(object sender, EventArgs e)
        {
            AddType at = new AddType();
            at.Owner = this;
            at.ShowDialog();
        }
    }
}
