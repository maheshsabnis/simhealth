using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    public class ManagerDTO : EmployeeDTO
    {
        public int HRA { get; set; }
        public int TA { get; set; }
        public int DA { get; set; }
        public int TeamMembers { get; set; }
        public int TeamWorkAllowance { get; set; }
    }
}
