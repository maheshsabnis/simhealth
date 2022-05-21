using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    internal class ManagerPayroll : PayrollBase
    {
        public override double CalculateTax(int netsalary)
        {
            TaxRules tax = new TaxRules();
            int slab = tax.GetTaxSlab(netsalary);
            return netsalary * ((double)slab / 100);
        }
        private int GetTeamWorkHours(int members)
        {
            return members * 22 * 10;
        }
        public override int CalculateIncome(EmployeeDTO emp)
        {
            ManagerDTO managerDTO = new ManagerDTO();
            managerDTO.Salary = emp.Salary;
            managerDTO.TeamMembers = 100;
            managerDTO.HRA = managerDTO.Salary * 2;
            managerDTO.TA = managerDTO.Salary * 2;
            managerDTO.DA = managerDTO.Salary * 2;

            return managerDTO.Salary + GetTeamWorkHours(managerDTO.TeamMembers) + managerDTO.HRA + managerDTO.TA + managerDTO.DA; 
            // As it is implemetation of BAse
            //return base.CalculateIncome(emp);
        }
    }
}
