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
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }

        private void typesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);

        }

        private void AddType_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Types". При необходимости она может быть перемещена или удалена.
            this.typesTableAdapter.Fill(this.computerFirmDataSet.Types);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);
            var nI = this.Owner as NewItem;
            var adapter = nI.getTypeAdapter();
            adapter.Update(nI.getDataSet());
            adapter.Fill(nI.getDataSet().Types);
        }
    }
}
