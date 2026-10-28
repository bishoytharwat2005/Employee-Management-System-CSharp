using System;

namespace Employ_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Id = 1,
                Name = "John Doe",
                Age = 35,
                Department = "Management",
                Salary = 5000,
                Bonus = 1000
            };

            Developer developer = new Developer
            {
                Id = 2,
                Name = "Jane Smith",
                Age = 28,
                Department = "Development",
                Salary = 4000,
                ProgrammingLanguage = "C#"
            };

            Employee emp = new Manager
            {
                Id = 3,
                Name = "Alice Johnson",
                Age = 40,
                Department = "Management",
                Salary = 6000,
                Bonus = 1500
            };

            EmployeeService emps = new EmployeeService();

            emps.AddEmployee(manager);
            emps.AddEmployee(developer);
            emps.AddEmployee(emp);

            int choice;
            int id;

            do
            {
                Console.WriteLine("\n===== Employee Management System =====");
                Console.WriteLine("1. View Employees");
                Console.WriteLine("2. Search Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please enter a valid number.");
                    choice = 0;
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        emps.ViewEmployees();
                        break;

                    case 2:
                        Console.Write("Enter employee ID: ");

                        if (int.TryParse(Console.ReadLine(), out id))
                            emps.SearchEmployee(id);
                        else
                            Console.WriteLine("Invalid ID.");

                        break;

                    case 3:
                        Console.Write("Enter employee ID: ");

                        if (int.TryParse(Console.ReadLine(), out id))
                            emps.UpdateEmployee(id);
                        else
                            Console.WriteLine("Invalid ID.");

                        break;

                    case 4:
                        Console.Write("Enter employee ID: ");

                        if (int.TryParse(Console.ReadLine(), out id))
                            emps.DeleteEmployee(id);
                        else
                            Console.WriteLine("Invalid ID.");

                        break;

                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 5);
        }
    }
}