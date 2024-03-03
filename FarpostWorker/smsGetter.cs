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
    public partial class smsGetter : Form
    {
        public smsGetter()
        {
            InitializeComponent();
        }

        private void smsGetter_Load(object sender, EventArgs e)
        {
            Variables.smsEntered = smsGet.Text;
        }

        private void sendSms_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ввод смс

    }
}
