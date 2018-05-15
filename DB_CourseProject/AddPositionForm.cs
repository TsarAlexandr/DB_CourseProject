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
    public partial class AddPositionForm : Form
    {
        public AddPositionForm()
        {
            InitializeComponent();
        }

        private void positionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);

        }

        private void AddPositionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.computerFirmDataSet.Positions);

        }

        private void fillParent(Form f)
        {
            var parent = f.Owner as Employees;
            var adapter2 = parent.getPosAdapter();
            adapter2.Update(parent.getDataSet());
            adapter2.Fill(parent.getDataSet().Positions);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);
            var f1 = this.Owner as Form1;
            var ae = this.Owner as AddEmployee;
            if (f1 != null)
            {
                var adapter = f1.getPosAdapter();
                adapter.Update(f1.getDataSet());
                adapter.Fill(f1.getDataSet().Positions);
                fillParent(f1);
            }
            if (ae != null)
            {
                var adapter = ae.getPosAdapter();
                adapter.Update(ae.getDataSet());
                adapter.Fill(ae.getDataSet().Positions);
                fillParent(ae);
                
            }
            this.Close();
        }
    }
}