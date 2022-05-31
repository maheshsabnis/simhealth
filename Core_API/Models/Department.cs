using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Core_API.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        [Required(ErrorMessage ="DeptNo is Mandatory")]
        public int DeptNo { get; set; }
        [Required(ErrorMessage = "DeptName is Mandatory")]
        // MaxLength, MinLength, Error Message
        [StringLength(40,MinimumLength = 5, ErrorMessage ="Mnimum 5 Characters are Required")]
        [NameVaidation('D',ErrorMessage ="First Character Must be 'D'")]
        public string DeptName { get; set; }
        [Required(ErrorMessage = "Capacity is Mandatory")]
        public int Capacity { get; set; }
        [Required(ErrorMessage = "Location is Mandatory")]
        public string Location { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
