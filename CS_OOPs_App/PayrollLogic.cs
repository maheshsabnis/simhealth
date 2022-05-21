using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    /// <summary>
    /// WIth Addition of new Designations as well as change in Payroll calculations 
    /// of existing Designaios, this class will need to be modified again and again 
    /// </summary>
    public class PayrollLogic
    {

        private int GetFlighTickerAmount()
        {
            return 10000;
        }

        private bool IsNewCustomerALigned()
        {
            return true;
        }

        public int DirectorPayroll(DirectorDTO director)
        {
            if (IsNewCustomerALigned())
            {
                return director.ProfitShare + director.Salary + GetFlighTickerAmount();
            }
            else
            {
                return director.ProfitShare + director.Salary;
            }
            
        }
        private int GetTeamWorkHours(int members)
        {
            return members * 22 * 10;
        }
        public int ManagerPayroll(ManagerDTO manager)
        {
            return GetTeamWorkHours(manager.TeamMembers) + manager.HRA + manager.TA + manager.DA + manager.Salary;
        }
    }
}
