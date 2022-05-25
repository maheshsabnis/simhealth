using System;
using System.Collections.Generic;

namespace CS_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");
            Dictionary<string, List<Employee>> employeesDb = new Dictionary<string, List<Employee>>();
            employeesDb.Add("IT", new List<Employee>()
            {
                new Employee(){ EmpNo=101,EmpName="Mahesh",Salary=120000},
                new Employee(){ EmpNo=102,EmpName="Vikram",Salary=220000},
            });

            employeesDb.Add("HR", new List<Employee>()
            {
                new Employee(){ EmpNo=103,EmpName="Vaibhav",Salary=320000},
                new Employee(){ EmpNo=104,EmpName="Vinit",Salary=220000},
                 new Employee(){ EmpNo=104,EmpName="Amit",Salary=240000},
            });
            // Read ALl Keys
            var keys = employeesDb.Keys;

            Console.WriteLine();
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }


            Console.WriteLine();
            foreach (var emp in employeesDb.Values)
            {
                emp.ForEach((data) =>
                {
                    Console.WriteLine($"{data.EmpNo} {data.EmpName} {data.Salary}");
                });
            }

            Console.WriteLine();
          
            Console.WriteLine("Data from IT");

            foreach (var key in employeesDb.Keys)
            {
                List<Employee> emps;
                var res = employeesDb.TryGetValue(key, out emps);
                if (res)
                {
                    Console.WriteLine($"Data form DeptName {key}");
                    emps.ForEach((data) =>
                    {
                        Console.WriteLine($"{data.EmpNo} {data.EmpName} {data.Salary}");
                    });
                }
                else
                {
                    Console.WriteLine($"No data for given key");
                }
            }
           


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
