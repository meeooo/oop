namespace EmployeeProject
{
    partial class EmployeeForm
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
            this.employeesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeSalary = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.managerBonus = new System.Windows.Forms.TextBox();
            this.addManager = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.managersList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeSalaryValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.changeSalary = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.managerBonusValue = new System.Windows.Forms.TextBox();
            this.changeBonus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesList
            // 
            this.employeesList.FormattingEnabled = true;
            this.employeesList.Location = new System.Drawing.Point(12, 25);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(270, 108);
            this.employeesList.TabIndex = 0;
            this.employeesList.SelectedIndexChanged += new System.EventHandler(this.employeesList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список сотрудников";
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(6, 139);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(146, 27);
            this.addEmployee.TabIndex = 2;
            this.addEmployee.Text = "Добавить сотрудника";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(6, 35);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(146, 20);
            this.employeeName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Зарплата";
            // 
            // employeeSalary
            // 
            this.employeeSalary.Location = new System.Drawing.Point(6, 74);
            this.employeeSalary.MaxLength = 10;
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.Size = new System.Drawing.Size(146, 20);
            this.employeeSalary.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addManager);
            this.groupBox1.Controls.Add(this.managerBonus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.employeeSalary);
            this.groupBox1.Controls.Add(this.addEmployee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.employeeName);
            this.groupBox1.Location = new System.Drawing.Point(288, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 235);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление сотрудников";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Бонус (менеджер)";
            // 
            // managerBonus
            // 
            this.managerBonus.Location = new System.Drawing.Point(6, 113);
            this.managerBonus.MaxLength = 10;
            this.managerBonus.Name = "managerBonus";
            this.managerBonus.Size = new System.Drawing.Size(146, 20);
            this.managerBonus.TabIndex = 8;
            // 
            // addManager
            // 
            this.addManager.Location = new System.Drawing.Point(6, 172);
            this.addManager.Name = "addManager";
            this.addManager.Size = new System.Drawing.Size(146, 27);
            this.addManager.TabIndex = 9;
            this.addManager.Text = "Добавить менеджера";
            this.addManager.UseVisualStyleBackColor = true;
            this.addManager.Click += new System.EventHandler(this.addManager_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Список менеджеров";
            // 
            // managersList
            // 
            this.managersList.FormattingEnabled = true;
            this.managersList.Location = new System.Drawing.Point(12, 152);
            this.managersList.Name = "managersList";
            this.managersList.Size = new System.Drawing.Size(270, 108);
            this.managersList.TabIndex = 9;
            this.managersList.SelectedIndexChanged += new System.EventHandler(this.managersList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changeBonus);
            this.groupBox2.Controls.Add(this.managerBonusValue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.changeSalary);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.changeSalaryValue);
            this.groupBox2.Location = new System.Drawing.Point(452, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 235);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение сотрудников";
            // 
            // changeSalaryValue
            // 
            this.changeSalaryValue.Location = new System.Drawing.Point(6, 35);
            this.changeSalaryValue.Name = "changeSalaryValue";
            this.changeSalaryValue.Size = new System.Drawing.Size(146, 20);
            this.changeSalaryValue.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Процент з/п";
            // 
            // changeSalary
            // 
            this.changeSalary.Location = new System.Drawing.Point(6, 61);
            this.changeSalary.Name = "changeSalary";
            this.changeSalary.Size = new System.Drawing.Size(146, 23);
            this.changeSalary.TabIndex = 2;
            this.changeSalary.Text = "Изменить з/п на процент";
            this.changeSalary.UseVisualStyleBackColor = true;
            this.changeSalary.Click += new System.EventHandler(this.changeSalary_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Бонус";
            // 
            // managerBonusValue
            // 
            this.managerBonusValue.Location = new System.Drawing.Point(6, 103);
            this.managerBonusValue.Name = "managerBonusValue";
            this.managerBonusValue.Size = new System.Drawing.Size(146, 20);
            this.managerBonusValue.TabIndex = 4;
            // 
            // changeBonus
            // 
            this.changeBonus.Enabled = false;
            this.changeBonus.Location = new System.Drawing.Point(6, 129);
            this.changeBonus.Name = "changeBonus";
            this.changeBonus.Size = new System.Drawing.Size(146, 23);
            this.changeBonus.TabIndex = 5;
            this.changeBonus.Text = "Изменить бонус";
            this.changeBonus.UseVisualStyleBackColor = true;
            this.changeBonus.Click += new System.EventHandler(this.changeBonus_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.managersList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesList);
            this.Name = "EmployeeForm";
            this.Text = "Employees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.TextBox managerBonus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox managersList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button changeSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox changeSalaryValue;
        private System.Windows.Forms.Button changeBonus;
        private System.Windows.Forms.TextBox managerBonusValue;
        private System.Windows.Forms.Label label7;
    }
}

