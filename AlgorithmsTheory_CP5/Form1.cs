using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorithmsTheory_CP5
{
    public partial class Form1 : Form
    {
        private LinearHashTable linearTable;
        private CuckooHashTable cuckooTable;
        private bool isLinear = true; // який метод зараз активний

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage2.Enabled = false;
            AddTab.Enabled = false;
            tabPage1.Enabled = false;
            tabPage3.Enabled = false;
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
            {
                linearTable = new LinearHashTable();
                isLinear = true;
            }
            else if (radioButton2.Checked)
            {
                cuckooTable = new CuckooHashTable();
                isLinear = false;
            }

            tabPage2.Enabled = true;
            AddTab.Enabled = true;
            tabPage1.Enabled = true;
            tabPage3.Enabled = true;
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
                string msg = isLinear
                    ? linearTable.Add(name, day, month)
                    : cuckooTable.Add(name, day, month);

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

            var data = isLinear
                ? linearTable.GetTable()
                : cuckooTable.GetTable();

            foreach (var line in data)
                listBoxTable.Items.Add(line);

            if (listBoxTable.Items.Count == 0)
                MessageBox.Show("Таблиця порожня");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // txtSearchDay, txtSearchMonth — твої текстові поля
            bool isDayOk = int.TryParse(txtSearchDay.Text, out int day);
            bool isMonthOk = int.TryParse(txtSearchMonth.Text, out int month);

            if (!isDayOk || day < 1 || day > 31 || !isMonthOk || month < 1 || month > 12)
            {
                MessageBox.Show("Введіть коректну дату!");
                return;
            }

            listBox1.Items.Clear(); // твій listbox на цій вкладці

            var results = isLinear
                ? linearTable.SearchByDate(day, month)
                : cuckooTable.SearchByDate(day, month);

            if (results.Count == 0)
                MessageBox.Show("Нікого не знайдено!");
            else
                foreach (var r in results)
                    listBox1.Items.Add(r);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtRemoveName.Text.Trim();
                bool isDayOk = int.TryParse(txtRemoveDate.Text.Trim(), out int day);
                bool isMonthOk = int.TryParse(txtRemoveMonth.Text.Trim(), out int month);

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

                string result = isLinear
                    ? linearTable.Remove(name, day, month)
                    : cuckooTable.Remove(name, day, month);

                MessageBox.Show(result);
                txtRemoveName.Clear();
                txtRemoveDate.Clear();
                txtRemoveMonth.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
    }
}
