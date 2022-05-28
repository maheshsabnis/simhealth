using System;
using System.Linq;
using EFCore_DbFirst.Models;
using Microsoft.EntityFrameworkCore;
using EFCore_DbFirst.DataAccessServices;
namespace EFCore_DbFirst
{
    internal class Program
    {
        static CompanyContext context = new CompanyContext();
        static void Main(string[] args)
        {
            Console.WriteLine("EF Core DB First");
            try
            {
                //// COde to Execute the external Dependencies
                //PrintDepts();
                //var dept = new Department()
                //{
                //    DeptNo = 30,
                //    DeptName = "SL",
                //    Location = "Pune",
                //    Capacity = 1000
                //};
                ////InsertDept(dept);

                //// UdateDept(30, dept);

                //DeleteDep(100);

                //Console.WriteLine();
                //PrintDepts();

                IDataAccess<Department, int> deptDa = new DepartmentDataAccess();
                deptDa.Create(new Department());

                IDataAccess<Employee, int> empDa = new EmployeeDataAccess();
                empDa.Create(new Employee());

                IDataAccess<string, int> str; 


            }
            catch (Exception ex)
            {
                // COde to be executed when the code in try block fails
                Console.WriteLine($"Error Occured {ex.Message}");
            }
            finally 
            {
                // the Mandatory ode whih MUST be executed irrespective of try or catch block
                Console.WriteLine("Doen Dana Done");
            }
            Console.ReadLine();
        }

        static void PrintDepts()
        {
            var depts = context.Departments.ToList();
            depts.ForEach((d) =>
            {
                Console.WriteLine($"{d.DeptNo} {d.DeptName} {d.Location} {d.Capacity}");
            });
        }
        static void InsertDept(Department dept)
        {
            var res = context.Departments.Add(dept);
            context.SaveChanges();
        }
        static void UdateDept(int id, Department dept)
        {
            if (id != dept.DeptNo)
            {
                Console.WriteLine($"The DeptNo {id} being updated does not match with Record Value {dept.DeptNo}");
                return;
            }
            Console.ReadLine();

            // update
            // 1. Serach a record based on Pk
            var deptToUpdate = context.Departments.Find(id);
            if (deptToUpdate == null)
            {
                Console.WriteLine("Record you are trying serach for upate is not found");
                return;
            }
            // 2. Update
            deptToUpdate.DeptName = dept.DeptName;
            deptToUpdate.Location = dept.Location;
            deptToUpdate.Capacity = dept.Capacity;
            context.SaveChanges();
           
        }

        static void DeleteDep(int id)
        {
            // search teh record
            var deptToDelete = context.Departments.Find(id);
            if (deptToDelete == null)
            {
                Console.WriteLine($"Record with {id} is not found");
                return;
            }
            context.Departments.Remove(deptToDelete);
            context.SaveChanges();
        }


    }
}
