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
    public partial class AddDevice : Form
    {
        public AddDevice()
        {
            InitializeComponent();
        }

        private void devicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.devicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);

        }

        private void AddDevice_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Devices". При необходимости она может быть перемещена или удалена.
            this.devicesTableAdapter.Fill(this.computerFirmDataSet.Devices);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.devicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);
            var nI = this.Owner as NewItem;
            var adapter = nI.getDevAdapter();
            adapter.Update(nI.getDataSet());
            adapter.Fill(nI.getDataSet().Devices);
                
            
        }
    }
}
