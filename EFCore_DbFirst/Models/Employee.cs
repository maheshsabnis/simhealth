using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore_DbFirst.Models
{
    public partial class Employee
    {
        // Primary Key
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public int DeptNo { get; set; }
        // Referential Integrity for varifying value for DeptNo
        public virtual Department DeptNoNavigation { get; set; }
    }
}
