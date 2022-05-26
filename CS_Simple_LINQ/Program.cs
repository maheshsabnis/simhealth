using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_Simple_LINQ
{
    internal class Program
    {
        static Employees empDb = new Employees();
        static Departments deptDb = new Departments();
        static void Main(string[] args)
        {
            Console.WriteLine("USing LINQ");
            // GetAllEmployees();
            //  GetAllEmployeesByDName("HR");
            // GetAllEmployeesOrderByEmpName();
            //  GetAllEmployeesSalaryGreaterThan10k();
            // GetAllEmployeesOrderByEmpNameDesc();
            //GetSumSalaryGroupByDeptName();
            //  GetMethodsTogether();
            // ImperativeGetAllEmps();
            //  ImperativeGroup();
            DeptEmp();
            Console.ReadLine();    
        }

        static void GetAllEmployees()
        {
            var res = empDb.Select(e => e);
            Print(res);
        }

        static void GetAllEmployeesSalaryGreaterThan10k()
        {
            var res = empDb.Where(e => e.Salary > 10000);
            Print(res);
        }

        static void GetAllEmployeesOrderByEmpName()
        {
            var res = empDb.OrderBy(e => e.EmpName);
            Print(res);
        }

        static void GetAllEmployeesOrderByEmpNameDesc()
        {
            var res = empDb.OrderByDescending(e => e.EmpName);
            Print(res);
        }

        static void GetAllEmployeesByDName(string dname)
        {
            var res = empDb.Where(e=>e.DeptName == dname);
            Print(res);
        }

        static void GetSumSalaryGroupByDeptName()
        {
            // The grup Key is the DeptName and the values will be an IENumerable<Employee>
            var res = empDb.GroupBy(e => e.DeptName);
            foreach (var item in res)
            {
                Console.WriteLine($"Key  = {item.Key} Sum Salary = {item.Sum(e=>e.Salary)}");
                
            }
        }

        static void GetMethodsTogether()
        {
            // using extension  metods in chain
            var res = empDb.Where(e => e.Salary > 7000)
                           .Select(e => e);
            
            Print(res);
        }
        static void Print(IEnumerable<Employee> result)
        {
            foreach (var e in result)
            {
                Console.WriteLine($"{e.EmpNo} {e.EmpName} {e.DeptName} {e.Salary}");
            }
        }

        static void ImperativeGetAllEmps()
        {
            // e is range variable aka each record in collection
            var res = from e in empDb
                      where e.Salary > 9000 // Where will mapped with Where<T>(condition) method
                      orderby e.EmpName descending // orderby mapped with OrderBy<T>() method
                      select e; // The 'select' will map with Select<T>() method
            Print(res);
        }

        static void ImperativeGroup()
        {
            var res = (from e in empDb
                      group e by e.DeptName into DeptGroup // For Each DeptName a group will be created
                                                           // of name DeptGroup
                      select new
                      {
                          DeptName = DeptGroup.Key,
                          Salary = DeptGroup.Sum(e => e.Salary)
                      }).ToList();
            foreach (var e in res)
            {
                Console.WriteLine($"DeptName = {e.DeptName} and Sum of Salary = {e.Salary}");
            }
        }

        static void DeptEmp()
        {
            var res = from d in deptDb
                      from e in empDb
                      where d.DeptName == e.DeptName
                      select new
                      {
                          EmpNo = e.EmpNo,
                          EmpName = e.EmpName,
                      };

            foreach (var item in res)
            {
                Console.WriteLine($"{item.EmpNo} {item.EmpName}");
            }
        }
    }

    internal class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }

    internal class Departments : List<Department>
    {
        public Departments()
        {
            Add(new Department() { DeptNo  =10, DeptName="IT"});
            Add(new Department() { DeptNo = 20, DeptName = "HR" });
            //Add(new Department() { DeptNo = 30, DeptName = "SL" });
        }
    }



    internal class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public int Salary { get; set; }
    }


    internal class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpNo = 101, EmpName = "Mahesh", DeptName = "IT", Salary = 11000 });
            Add(new Employee() { EmpNo = 102, EmpName = "Tejas", DeptName = "HR", Salary = 12000 });
            Add(new Employee() { EmpNo = 103, EmpName = "Nandu", DeptName = "SL", Salary = 13000 });
            Add(new Employee() { EmpNo = 104, EmpName = "Anil", DeptName = "IT", Salary = 14000 });
            Add(new Employee() { EmpNo = 105, EmpName = "Jaywant", DeptName = "HR", Salary = 10000 });
            Add(new Employee() { EmpNo = 106, EmpName = "Abhay", DeptName = "SL", Salary = 9000 });
            Add(new Employee() { EmpNo = 107, EmpName = "Anil", DeptName = "IT", Salary = 8000 });
            Add(new Employee() { EmpNo = 108, EmpName = "Shyam", DeptName = "HR", Salary = 7000 });
            Add(new Employee() { EmpNo = 109, EmpName = "Vikram", DeptName = "SL", Salary = 6000 });
            Add(new Employee() { EmpNo = 110, EmpName = "Suprotim", DeptName = "IT", Salary = 5000 });
        }
    }
}
