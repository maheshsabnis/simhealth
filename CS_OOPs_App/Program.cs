using System;
using System.Collections;

namespace CS_OOPs_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDTO emp = new EmployeeDTO();
            EmployeeLogic logic = new EmployeeLogic();
            Console.WriteLine("ENter EMployee Information as EmpNo, EmpName, Salary, Designation, DeptNAme in this order only");
            // Set values for propertes
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());
            emp.EmpName = Console.ReadLine();
            emp.Salary = Convert.ToInt32(Console.ReadLine());
            emp.Designation = Console.ReadLine();
            emp.DeptName = Console.ReadLine();
            // Un-Necessary Hard Coding (Remove it)
            //if (emp.DeptName != "IT" || emp.DeptName != "HR" || emp.DeptName != "TR")
            //{
            //    Console.WriteLine("Sorry DeptName is Not acceptable");
            //    return;
            //}
            // pass data to the AddEmployee() method of Logic class
            logic.AddEmployee(emp);

            ArrayList emps = logic.GetEmployees();
            Console.WriteLine($"EmpNo \t EmpName \t Salary \t Designation \t DeptName");
            foreach (EmployeeDTO item in emps)
            {
                Console.WriteLine($"{item.EmpNo}\t{item.EmpName}\t{item.Salary}\t{item.Designation}\t{item.DeptName} ");
            }


            Console.WriteLine("Employee Infromation System");
            Console.ReadLine();
        }
    }
}
