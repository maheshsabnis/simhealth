using System;
using System.Collections;
namespace CS_New_Cllections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMO COllectons");
            ArrayList arrList = new ArrayList();
            arrList.Add(10);
            arrList.Add(20);
            arrList.Add(30);
            arrList.Add(40);
            arrList.Add("Tejas");
            arrList.Add("Mahesh");
            arrList.Add("Ramesh");
            arrList.Add("Ram");
            arrList.Add("Sabnis");
            arrList.Add('A');
            arrList.Add('B');
            arrList.Add('C');
            arrList.Add('D');
            arrList.Add(10.20);
            arrList.Add(20.30);
            arrList.Add(30.40);
            arrList.Add(40.50);
            arrList.Add(new Employee(1, "A1"));
            arrList.Add(new Employee(2, "A2"));
            arrList.Add(new Employee(3, "A3"));
            Console.WriteLine($"Length of array list = {arrList.Count}");
            /// read only strings
            foreach (object obj in arrList)
            {
                if (obj.GetType() == typeof(string))
                {
                    Console.WriteLine($"Name = {obj}");
                }
            }
            Console.WriteLine();
            foreach (object obj in arrList)
            {
                if (obj.GetType() == typeof(Employee))
                {
                    // Cast the obj to Employee
                    ((Employee)obj).PrintInfo();
                }
            }
            Console.ReadLine();    
        }
    }

    internal class Employee
    {
        private int _EmpNo;
        private string _EmpName;    
        public Employee(int eno, string ename)
        {
            _EmpNo = eno;
            _EmpName = ename;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"EmpNo {_EmpNo}, EmpName {_EmpName}");
        }
    }
}
