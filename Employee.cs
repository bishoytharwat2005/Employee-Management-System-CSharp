using System;

namespace Employ_System
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                        "Salary cannot be negative.");

                salary = value;
            }
        }

        public abstract decimal CalculateSalary();
    }
}