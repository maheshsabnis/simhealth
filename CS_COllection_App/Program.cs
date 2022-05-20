using System;
using System.Collections;
namespace CS_COllection_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lstEmps = new ArrayList();
            Console.WriteLine("Collection Based Application");
            // ACcept data from End-USer 5 Times
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Employee DEtails Like EMpNo, EMpame and Salary");
                // Accept Data from End-User
                int eno = Convert.ToInt32(Console.ReadLine());
                string ename = Console.ReadLine();
                int sal = Convert.ToInt32(Console.ReadLine());
                // Store the Data in EMployee Object
                Employee emp = new Employee(eno, ename, sal);
                // Store employee in ARrayList
                lstEmps.Add(emp); // emp is stored as Object
            }
            

            foreach (object e in lstEmps)
            {
                ((Employee)e).PrintInfo();
            }

            Console.ReadLine();
        }
    }


    internal class Employee
    {
        private int _EmpNo;
        private string _EmpName;
        private int _Salary;
        public Employee(int eno, string ename, int salary)
        {
            _EmpNo = eno;
            _EmpName = ename;
            _Salary = salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"EmpNo {_EmpNo}, EmpName {_EmpName}, Salary {_Salary}");
        }
    }
}
