﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarpostWorker
{
    public partial class AddPriceLists : Form
    {
        public AddPriceLists()
        {
            InitializeComponent();
        }

        private void pricesNamesDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.pricesNamesDataView.Columns.Add("Название проекта", "Name");
        }

        private void addPrice_Click(object sender, EventArgs e)
        {
            addTriggers run = new addTriggers();
            run.Show();
        }
    }
}
