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
    public partial class ConditionsEdit : Form
    {
        public ConditionsEdit()
        {
            InitializeComponent();

            string[] weekDays = { "Пн", "Вт", "Ср", "Чт", "Пт", "Суб", "Вск" };

            for (int i = 0; i < weekDays.Length; i++)
            {
                CheckListDays.Items.Add(weekDays[i], false); // Изначально все дни недели не отмечены
            }
        }

        public void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string checkedItem = CheckListDays.Items[e.Index].ToString();
            bool isChecked = (e.NewValue == CheckState.Checked);

            Console.WriteLine($"{checkedItem} {(isChecked ? "отмечен" : "не отмечен")}");
        }
    }
}
