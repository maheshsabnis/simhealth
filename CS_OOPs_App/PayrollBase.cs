using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    public abstract class PayrollBase
    {
        /// <summary>
        /// Virtual Method with Default Impemetation
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public virtual int CalculateIncome(EmployeeDTO emp)
        {
            return emp.Salary;
        }
        public abstract double CalculateTax(int netsalary);
         
    }
}
