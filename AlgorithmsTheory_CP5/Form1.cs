using System;
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
                hashTable = new HashTable(10, 1);
            else if (radioButton2.Checked)
                hashTable = new HashTable(10, 2);

            tabPage2.Enabled = true;
            AddTab.Enabled = true;
            tabPage1.Enabled = true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string date = txtDate.Text.Trim();

            if (name == "" || date == "")
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }
            string result = hashTable.Add(name, date);
            MessageBox.Show(result);

            txtName.Clear();
            txtDate.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = txtRemoveName.Text.Trim();
            string date = txtRemoveDate.Text.Trim();

            if (name == "" || date == "")
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }

            string result = hashTable.Remove(name, date);
            MessageBox.Show(result);

            txtRemoveName.Clear();
            txtRemoveDate.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBoxTable.Items.Clear();

            var table = hashTable.GetTable();
            foreach (string row in table)
                listBoxTable.Items.Add(row);
        }
    }
}
