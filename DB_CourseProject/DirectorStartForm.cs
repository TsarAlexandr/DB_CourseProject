﻿using System;
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
    public partial class DirectorStartForm : Form
    {
        public DirectorStartForm()
        {
            InitializeComponent();
        }

        private void buttonGetItems_Click(object sender, EventArgs e)
        {
            NewItem ni = new NewItem();
            ni.ShowDialog();
        }

        private void buttonGetReport_Click(object sender, EventArgs e)
        {
            GeneralReport gr = new GeneralReport();
            gr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChartForm chart = new ChartForm();
            chart.Owner = this;
            chart.Show();
        }
    }
}
