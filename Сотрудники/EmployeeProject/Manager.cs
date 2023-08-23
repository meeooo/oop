
namespace EmployeeProject
{
    internal class Manager : Employee
    {
        private float bonus;

        public Manager() : this(string.Empty, 0f, 0f)
        {
            
        }

        public Manager(string name) : this(name, 0f, 0f)
        {

        }

        public Manager(string name, float salary) : this(name, salary, 0f)
        {

        }

        public Manager(string name, float salary, float bonus) : base(name, salary)
        {
            this.bonus = bonus;
        }

        public float GetBonus() => bonus;

        public float IncreaseBonus(float amount) => bonus += amount;

        public override string ToString()
        {
            return $"[Менеджер] имя: {GetName()}, з/п: {GetSalary():0.00}, бонус: {bonus:0.00}";
        }
    }
}
