using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    public class EmployeeLogic
    {
        private ArrayList Employees;

        public EmployeeLogic()
        {
            Employees = new ArrayList();
        }

        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="emp"></param>
        public void AddEmployee(EmployeeDTO emp)
        {
            // Un-Necessary Hard Coding (Remove it)
            //if (emp.DeptName != "IT" || emp.DeptName != "HR" || emp.DeptName != "TR")
            //{
            //    Console.WriteLine("Sorry DeptName is Not acceptable");
            //    return;
            //}
            Employees.Add(emp);
        }
        /// <summary>
        /// Read Employees
        /// </summary>
        /// <returns></returns>
        public ArrayList GetEmployees()
        {
            return Employees;
        }
    }
}
