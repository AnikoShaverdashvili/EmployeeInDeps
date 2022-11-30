using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInDeps
{
    public class Department
    {
        private string _name;
        private int _numOfEmployee;
        public List<Employee> _employee = new List<Employee>();
        public List<Employee> Employee { get => _employee; set => _employee = value; }
        public int NumOfEmployee { get => _numOfEmployee; set => _numOfEmployee = value; }

        public Department(string name, int numOfEmployee)
        {
            _name = name;
            _numOfEmployee = numOfEmployee;
        }

        public Department()
        {
        }



        /// <summary>
        /// Prints Department List
        /// </summary>
        /// <param name="department"></param>

        public void PrintDepartmentList(List<Department> department)
        {
            foreach (var dep in department)
            {
                Console.WriteLine(dep);
            }
        }

    }

}