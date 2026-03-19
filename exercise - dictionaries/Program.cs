namespace exercise___dictionaries
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace EmployeeDictionaryApp
    {



        /* EXERCISE 
         * Create an employees Dictionary <int EmpID, List<Employee>>()
         * 
         * The dictionary will store the following details:
         * 1. The employee number and employee details
         * Employee Details are from a separate class Employee and are as follows:
         * 1. EmpID
         * 2. EmpName
         * 3. EmpSurname
         * 4. EmpSalary
         * 5. EmpPosition
         * 
         * 2. Create a method searchEmp(int EmpID)
         * That searches for an employee using the EmpID
         * 
         * 3.create a method searchEmpDetails(string value)
         * That allows searching the dictionary using employee details
         * This method must return all matches from the List<Employee>
         */

        class Program
        {
            // Dictionary storing <EmpID, List<Employee>>
            static Dictionary<int, List<Employee>> employees = new Dictionary<int, List<Employee>>();

            static void Main(string[] args)
            {
                // Adding sample data
                AddSampleEmployees();

                // Search by EmpID
                Console.WriteLine("Search by EmpID 101:");
                var emp = SearchEmp(101);
                if (emp != null)
                    foreach (var e in emp)
                        Console.WriteLine(e);
                else
                    Console.WriteLine("Employee not found.");

                Console.WriteLine("\nSearch by any detail 'Manager':");
                var results = SearchEmpDetails("Manager");
                foreach (var e in results)
                    Console.WriteLine(e);

                Console.ReadLine();
            }

            // Adds some sample employees to the dictionary
            static void AddSampleEmployees()
            {
                employees[101] = new List<Employee>()
            {
                new Employee(101, "John", "Doe", 50000, "Manager")
            };
                employees[102] = new List<Employee>()
            {
                new Employee(102, "Jane", "Smith", 40000, "Developer")
            };
                employees[103] = new List<Employee>()
            {
                new Employee(103, "Mike", "Brown", 45000, "Developer"),
                new Employee(103, "Michael", "Brown", 47000, "Senior Developer") // multiple employees with same EmpID
            };
            }

            // Method 1: Search by EmpID
            static List<Employee> SearchEmp(int empID)
            {
                if (employees.ContainsKey(empID))
                    return employees[empID];
                return null;
            }

            // Method 2: Search by any detail
            static List<Employee> SearchEmpDetails(string value)
            {
                List<Employee> matches = new List<Employee>();

                foreach (var empList in employees.Values)
                {
                    foreach (var emp in empList)
                    {
                        if (emp.EmpID.ToString().Contains(value) ||
                            emp.EmpName.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                            emp.EmpSurname.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                            emp.EmpSalary.ToString().Contains(value) ||
                            emp.EmpPosition.Contains(value, StringComparison.OrdinalIgnoreCase))
                        {
                            matches.Add(emp);
                        }
                    }
                }

                return matches;
            }
        }
    }
}



