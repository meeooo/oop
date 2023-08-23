using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeProject
{
    public partial class EmployeeForm : Form
    {
        private List<Employee> employees = new List<Employee>();
        private List<Manager> managers = new List<Manager>();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void addEmployee_Click(object sender, System.EventArgs e)
        {
            Employee employee;
            if (employeeName.Text.Length == 0)
                employee = new Employee();
            else if (float.TryParse(employeeSalary.Text, out float salary))
                employee = new Employee(employeeName.Text, salary);
            else
                employee = new Employee(employeeName.Text);

            employees.Add(employee);
            employeesList.Items.Add(employee.ToString());
        }

        private void addManager_Click(object sender, System.EventArgs e)
        {
            Manager manager;
            if (employeeName.Text.Length == 0)
                manager = new Manager();
            else if (float.TryParse(employeeSalary.Text, out float salary))
            {
                if (float.TryParse(managerBonus.Text, out float bonus))
                    manager = new Manager(employeeName.Text, salary, bonus);
                else
                    manager = new Manager(employeeName.Text, salary);
            }
            else
                manager = new Manager(employeeName.Text);

            managers.Add(manager);
            managersList.Items.Add(manager.ToString());
        }

        private void changeSalary_Click(object sender, System.EventArgs e)
        {
            if (!int.TryParse(changeSalaryValue.Text, out int percent))
                return;

            if (employeesList.SelectedIndex != -1)
            {
                Employee employee = employees[employeesList.SelectedIndex];
                ChangeSalary(employeesList, employee, employeesList.SelectedIndex, percent);
            }
            else if (managersList.SelectedIndex != -1)
            {
                Employee employee = managers[managersList.SelectedIndex];
                ChangeSalary(managersList, employee, managersList.SelectedIndex, percent);
            }
        }

        private void ChangeSalary(ListBox list, Employee employee, int index, int percent)
        {
            employee.IncreaseSalary(percent);
            list.Items.RemoveAt(index);
            list.Items.Insert(index, employee.ToString());
            list.Update();
        }

        private void employeesList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (employeesList.Focused)
                managersList.SelectedItem = null;
        }

        private void managersList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            changeBonus.Enabled = managersList.Focused && managersList.SelectedIndex != -1;
            if (managersList.Focused)
                employeesList.SelectedItem = null;
        }

        private void changeBonus_Click(object sender, System.EventArgs e)
        {
            if (!float.TryParse(managerBonusValue.Text, out float bonus))
                return;

            int index = managersList.SelectedIndex;

            if (index == -1)
                return;

            var manager = managers[index];

            manager.IncreaseBonus(bonus);
            managersList.Items.RemoveAt(index);
            managersList.Items.Insert(index, manager.ToString());
            managersList.Update();
        }
    }
}
