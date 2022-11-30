using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInDeps
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _employeeID;
        private decimal _employeeSalary;
        private Department _department;

        public Employee(string firstName, string lastName, string employeeID, decimal employeeSalary, Department department)
        {
            _firstName = firstName;
            _lastName = lastName;
            _employeeID = employeeID;
            _employeeSalary = employeeSalary;
            _department = department;
        }

        /// <summary>
        /// Adds Employee in list
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="department"></param>

        public void AddEmployee(Employee employee, Department department)
        {

            if (_department.Employee.Count < _department.NumOfEmployee && _department.Employee.Contains(employee))
            {

                _department._employee.Add(employee);
            }
        }

        /// <summary>
        /// Deletes employee from list 
        /// </summary>
        /// <param name="employee"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>

        public void DeleteEmployee(Employee employee)
        {
            if (_department.Employee == null || _department.Employee?.Count == 0)
            {
                throw new IndexOutOfRangeException("Employee list is empty");
            }
            else
            {
                _department._employee.Remove(employee);
            }

        }
        /// <summary>
        /// Prints employee list
        /// </summary>
        /// <param name="employee"></param>
        public void PrintEmployeeList()
        {
            foreach (var emp in _department.Employee)
            {
                Console.WriteLine(emp);
            }
        }

        /// <summary>
        /// Prints Employee number in Departments
        /// </summary>
        /// <returns></returns>
        public int CountEmpInDep()
        {
            if (_department == null)
            {
                return 0;
            }

            return _department.Employee.Count();
        }

    }
}