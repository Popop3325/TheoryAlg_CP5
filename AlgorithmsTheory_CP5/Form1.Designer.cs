namespace AlgorithmsTheory_CP5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SelectHash = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.AddTab = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRemoveDate = new System.Windows.Forms.TextBox();
            this.txtRemoveName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxTable = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SelectHash.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AddTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SelectHash);
            this.tabControl1.Controls.Add(this.AddTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 419);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // SelectHash
            // 
            this.SelectHash.Controls.Add(this.panel1);
            this.SelectHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectHash.Location = new System.Drawing.Point(4, 25);
            this.SelectHash.Name = "SelectHash";
            this.SelectHash.Padding = new System.Windows.Forms.Padding(3);
            this.SelectHash.Size = new System.Drawing.Size(666, 390);
            this.SelectHash.TabIndex = 0;
            this.SelectHash.Text = "Обрати хеш-функцію";
            this.SelectHash.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(214, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 83);
            this.panel1.TabIndex = 1;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(121, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Поліноміальна";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(193, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "За сумою символів (ASCII)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AddTab
            // 
            this.AddTab.Controls.Add(this.btnAdd);
            this.AddTab.Controls.Add(this.txtDate);
            this.AddTab.Controls.Add(this.txtName);
            this.AddTab.Controls.Add(this.label2);
            this.AddTab.Controls.Add(this.label1);
            this.AddTab.Location = new System.Drawing.Point(4, 25);
            this.AddTab.Name = "AddTab";
            this.AddTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTab.Size = new System.Drawing.Size(666, 390);
            this.AddTab.TabIndex = 1;
            this.AddTab.Text = "Додати студента ";
            this.AddTab.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(290, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(344, 167);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(344, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "День народження";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.txtRemoveDate);
            this.tabPage1.Controls.Add(this.txtRemoveName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 390);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Видалити студента";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(290, 220);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Видалити";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRemoveDate
            // 
            this.txtRemoveDate.Location = new System.Drawing.Point(348, 170);
            this.txtRemoveDate.Name = "txtRemoveDate";
            this.txtRemoveDate.Size = new System.Drawing.Size(100, 22);
            this.txtRemoveDate.TabIndex = 8;
            // 
            // txtRemoveName
            // 
            this.txtRemoveName.Location = new System.Drawing.Point(348, 148);
            this.txtRemoveName.Name = "txtRemoveName";
            this.txtRemoveName.Size = new System.Drawing.Size(100, 22);
            this.txtRemoveName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "День народження";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ім\'я";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShow);
            this.tabPage2.Controls.Add(this.listBoxTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 390);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Таблиця студентів";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxTable
            // 
            this.listBoxTable.FormattingEnabled = true;
            this.listBoxTable.ItemHeight = 16;
            this.listBoxTable.Location = new System.Drawing.Point(132, 73);
            this.listBoxTable.Name = "listBoxTable";
            this.listBoxTable.Size = new System.Drawing.Size(407, 228);
            this.listBoxTable.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(281, 308);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Показати";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(702, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.SelectHash.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddTab.ResumeLayout(false);
            this.AddTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SelectHash;
        private System.Windows.Forms.TabPage AddTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtRemoveDate;
        private System.Windows.Forms.TextBox txtRemoveName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxTable;
        private System.Windows.Forms.Button btnShow;
    }
}

