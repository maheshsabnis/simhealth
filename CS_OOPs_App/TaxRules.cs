using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    /// <summary>
    /// Class whih cannot be derived
    /// </summary>
    internal sealed class TaxRules
    {
        public int GetTaxSlab(int salary)
        {
            if (salary >= 10000 || salary <= 50000)
                return 10;
            if (salary > 50000 || salary <= 100000)
                return 20;

            return 30;
        }
    }

   
}
