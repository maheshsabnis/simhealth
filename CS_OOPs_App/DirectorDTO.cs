using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    /// <summary>
    /// Every Director is an EMployee
    /// 
    /// The : is the syntx for the Derivation /  Inheritence
    /// 
    /// </summary>
    public class DirectorDTO : EmployeeDTO
    {
        public int ProfitShare {get;set;}
        public int Alloances { get; set; }
    }

}
