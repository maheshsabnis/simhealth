using System;
using System.Collections.Generic;
namespace CS_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geneics");
            // a Copy of List for integer values 
            List<int> lstInt = new List<int>();
            lstInt.Add(10);
            lstInt.Add(20);
            lstInt.Add(30);
            lstInt.Add(40);
            lstInt.Add(50);
            lstInt.Add(10);
            lstInt.Add(20);
            lstInt.Add(30);
            lstInt.Add(40);
            lstInt.Add(50);
            lstInt.Add(10);
            lstInt.Add(20);
            lstInt.Add(30);
            lstInt.Add(40);
            lstInt.Add(50);

            foreach (int val in lstInt)
            {
                Console.WriteLine($"Integer val = {val}");
            }
            // Search the Last Idnex of 10
            // Hay, Method take v as input para,eter with value as 10
            // and returns the index of its Last idnex
            
            int lastIndex = lstInt.FindLastIndex(v => v == 10);

            var result = lstInt.FindAll(v => v > 45);
            foreach (int val in result)
            {
            Console.WriteLine($"All greater than 45 = {val}");

            }

            Console.WriteLine($"Last index of 10 = {lastIndex}");
            Console.WriteLine();
            List<string> lstStr = new List<string>();
            lstStr.Add("Tejas");
            lstStr.Add("Mahesh");
            lstStr.Add("Ramesh");
            lstStr.Add("Sabnis");

            foreach (string str in lstStr)
            {
                Console.WriteLine($"String str = {str}");
            }

            List<Employee> lstEmp = new List<Employee>();
                                        // Object Initializer
            lstEmp.Add(new Employee() {EmpNo = 101, EmpName="Mahesh",Salary=45000 });
            lstEmp.Add(new Employee() { EmpNo = 102, EmpName = "Vikram", Salary = 55000 });
            lstEmp.Add(new Employee() { EmpNo = 1013, EmpName = "Subodh", Salary = 41000 });

            foreach (Employee emp in lstEmp)
            {
                Console.WriteLine($"EMpNo = {emp.EmpNo} EmpName = {emp.EmpName}");
            }

            Console.WriteLine("Print all Employees having salary more than 42k");

            var emps = lstEmp.FindAll(e=>e.Salary > 42000);

            emps.ForEach(e=> {
                Console.WriteLine(e.EmpName);
            });

            Console.ReadLine();    
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
    }
}
