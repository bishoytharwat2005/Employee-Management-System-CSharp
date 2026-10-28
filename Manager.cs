namespace Employ_System
{
    public class Manager : Employee
    {
        public decimal Bonus { get; set; }

        public override decimal CalculateSalary()
        {
            return Salary + Bonus;
        }
    }
}