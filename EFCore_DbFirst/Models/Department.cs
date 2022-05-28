using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore_DbFirst.Models
{
    public partial class Department : EntityBase
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        // Primary Key
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        // One-to-Many Ralations
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
