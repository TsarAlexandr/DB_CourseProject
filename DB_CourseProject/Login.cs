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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void employees1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employees1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computerFirmDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerFirmDataSet.Employees1". При необходимости она может быть перемещена или удалена.
            this.employees1TableAdapter.Fill(this.computerFirmDataSet.Employees1);

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(textBox2.Text);
            string name = textBox1.Text;
            
                var user = computerFirmDataSet.Employees1.FindByempId(id);
                if ((user != null && id != 0) && (user["surname"].ToString() == name))
                {
                    this.Visible = false;
                    int pos = Int32.Parse(user["posId"].ToString());
                    if (pos == 1)
                    {
                        DirectorStartForm dsf = new DirectorStartForm();
                        dsf.ShowDialog();
                    }
                    else if (pos == 2)
                    {
                        StartForm sf = new StartForm();
                        sf.ShowDialog();
                    }
                    else
                    {
                        SalesManagerStartForm sms = new SalesManagerStartForm(id);
                        sms.ShowDialog();
                    }

                    textBox1.Clear();
                    textBox2.Clear();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Incorrect data");
                }
           

        }
    }
}
