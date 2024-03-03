using MySql.Data.MySqlClient;
using MySqlHelper;
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
    public partial class addTriggers : Form
    {
        DbHelper dbhelper = new DbHelper();
        public addTriggers()
        {
            InitializeComponent();
            dbhelper.OpenConnection();
        }

        public void addTriggersBtn_Click(object sender, EventArgs e)
        {
            // Получаем текст для добавления из окна редактирования условий (ConditionsEdit)
            string newText = GetTextFromConditionsEdit(); // Это должно быть ваше собственное решение для получения текста

            // Добавляем текст в список
            AddedTriggersList.Items.Add(newText);

            // Сохраняем список
            SaveAddedTriggersList(newText);
        }

        public void SaveAddedTriggersList(string text)
        {
            try
            {
                string query = $"INSERT INTO `TriggersList`(`TrigName`) VALUES ('{text}')";
                using (MySqlCommand insertSubs = new MySqlCommand(query, dbhelper.Connection))
                {
                    insertSubs.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetTextFromConditionsEdit()
        {
            ConditionsEdit conditionsEdit = new ConditionsEdit();
            if (conditionsEdit.CheckListDays.SelectedItem != null)
            {
                return conditionsEdit.CheckListDays.SelectedItem.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public void AddedTriggersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTrigger = AddedTriggersList.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedTrigger))
            {
                Console.WriteLine($"Выбран триггер: {selectedTrigger}");
            }
            else
            {
                Console.WriteLine("Ничего не выбрано.");
            }
        }
    }
}
