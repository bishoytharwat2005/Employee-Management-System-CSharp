namespace Employ_System
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public override decimal CalculateSalary()
        {
            return Salary + 2000;
        }
    }
}