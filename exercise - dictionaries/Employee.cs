using System;
using System.Collections.Generic;
using System.Text;

namespace exercise___dictionaries
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpSurname { get; set; }
        public decimal EmpSalary { get; set; }
        public string EmpPosition { get; set; }

        public Employee(int id, string name, string surname, decimal salary, string position)
        {
            EmpID = id;
            EmpName = name;
            EmpSurname = surname;
            EmpSalary = salary;
            EmpPosition = position;
        }

        public override string ToString()
        {
            return $"ID: {EmpID}, Name: {EmpName} {EmpSurname}, Salary: {EmpSalary}, Position: {EmpPosition}";
        }
    }
}
