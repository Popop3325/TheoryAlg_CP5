using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AlgorithmsTheory_CP5  
{
    public partial class Form1 : Form
    {
        private HashTable hashTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage2.Enabled = false;
            AddTab.Enabled = false;
            tabPage1.Enabled = false;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
                e.Cancel = true;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ActivateTabs();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ActivateTabs();
        }

        private void ActivateTabs()
        {
            if (radioButton1.Checked)
                hashTable = new HashTable(1);
            else if (radioButton2.Checked)
                hashTable = new HashTable(2);

            tabPage2.Enabled = true;
            AddTab.Enabled = true;
            tabPage1.Enabled = true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Будь ласка, введіть ім'я студента.");
                return;
            }

            bool isDayOk = int.TryParse(txtDate.Text, out int day);
            bool isMonthOk = int.TryParse(txtMonth.Text, out int month);

            if (!isDayOk || day < 1 || day > 31)
            {
                MessageBox.Show("Введіть коректне число дня (1-31).");
                return;
            }

            if (!isMonthOk || month < 1 || month > 12)
            {
                MessageBox.Show("Введіть коректне число місяця (1-12).");
                return;
            }

            try
            {
                string msg = hashTable.Add(name, day, month);
                MessageBox.Show(msg);

                txtName.Clear();
                txtDate.Clear();
                txtMonth.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла системна помилка: {ex.Message}");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBoxTable.Items.Clear();
            var data = hashTable.GetTable();
            foreach (var line in data)
            {
                listBoxTable.Items.Add(line);
            }
            if (listBoxTable.Items.Count == 0) MessageBox.Show("Таблиця порожня");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtRemoveName.Text.Trim();
                int day = int.Parse(txtRemoveDate.Text.Trim());   
                int month = int.Parse(txtRemoveMonth.Text.Trim()); 

                string result = hashTable.Remove(name, day, month);
                MessageBox.Show(result);

                txtRemoveName.Clear();
                txtRemoveDate.Clear();
                txtRemoveMonth.Clear();
            }
            catch
            {
                MessageBox.Show("Будь ласка, введіть коректні дані для видалення (числа в полях дати)!");
            }
        }

        
    }
}
