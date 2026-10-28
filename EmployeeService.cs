using System;
using System.Collections.Generic;

namespace Employ_System
{
    public class EmployeeService
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DeleteEmployee(int id)
        {
            Employee employeeToDelete = null;

            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    employeeToDelete = employee;
                    break;
                }
            }

            if (employeeToDelete != null)
            {
                employees.Remove(employeeToDelete);
                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        public void UpdateEmployee(int id)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    Console.Write("Enter new name: ");
                    employee.Name = Console.ReadLine();

                    Console.Write("Enter new department: ");
                    employee.Department = Console.ReadLine();

                    Console.WriteLine("Employee updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Employee not found.");
        }

        public void SearchEmployee(int id)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    Console.WriteLine($"ID: {employee.Id}");
                    Console.WriteLine($"Name: {employee.Name}");
                    Console.WriteLine($"Age: {employee.Age}");
                    Console.WriteLine($"Department: {employee.Department}");
                    Console.WriteLine($"Salary: {employee.Salary}");
                    Console.WriteLine($"Total Salary: {employee.CalculateSalary()}");
                    return;
                }
            }

            Console.WriteLine("Employee not found.");
        }

        public void ViewEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine(
                    $"ID: {employee.Id}, " +
                    $"Name: {employee.Name}, " +
                    $"Age: {employee.Age}, " +
                    $"Department: {employee.Department}, " +
                    $"Salary: {employee.Salary}, " +
                    $"Total Salary: {employee.CalculateSalary()}");
            }
        }

        public void SearchEmployee(string name)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Name.Equals(
                    name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(
                        $"ID: {employee.Id}, Name: {employee.Name}");
                    return;
                }
            }

            Console.WriteLine("Employee not found.");
        }

        public void SearchEmployee(Employee employee)
        {
            if (employee != null)
                Console.WriteLine(employee.Name);
            else
                Console.WriteLine("Employee not found.");
        }
    }
}