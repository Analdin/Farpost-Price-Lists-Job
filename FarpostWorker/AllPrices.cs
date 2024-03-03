using System;
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
    public partial class AllPrices : Form
    {
        public AllPrices()
        {
            InitializeComponent();
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            AddPriceLists run = new AddPriceLists();
            run.Show();
        }
    }
}
