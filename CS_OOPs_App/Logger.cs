using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    internal static class Logger
    {
        public static void Log(EmployeeDTO employee)
        {
            Console.WriteLine($"Current Processed Employee is {employee.EmpNo} {employee.EmpName} {employee.DeptName}");
        }
    }
}
