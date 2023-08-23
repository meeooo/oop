
namespace EmployeeProject
{
    public class Employee
    {
        private string name;
        private float salary;

        public Employee() : this(string.Empty, 0f)
        {

        }

        public Employee(string name) : this(name, 0f)
        {

        }

        public Employee(string name, float salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string GetName() => name;
        public float GetSalary() => salary;

        public void IncreaseSalary(int percent)
        {
            float ratio = 1f + 0.01f * percent;
            salary *= ratio;
        }

        public override string ToString()
        {
            return $"[Сотрудник] имя: {name}, з/п: {salary:0.00}";
        }
    }
}
