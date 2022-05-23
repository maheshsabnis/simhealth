using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    /// <summary>
    /// Class with Overloaded Methods
    /// </summary>
    internal class GeneralTaxes
    {
        public double CalculateTax(int netIncome)
        {
            return netIncome * 0.08;
        }

        public double CalculateTax(int netIncome, int eduExpenses)
        {
            return (netIncome * 0.08) - eduExpenses;
        }

        public double CalculateTax(int netIncome, int eduExpenses, int metroTax)
        {
            return (netIncome * 0.08) - eduExpenses - metroTax;
        }

        public double CalculateTax(int netIncome, int eduExpenses, int metroTax, int waterTax)
        {
            return (netIncome * 0.08) - eduExpenses - metroTax - waterTax;
        }

        public double CalculateTax(int netIncome, int eduExpenses, int metroTax, int waterTax, int powerTax)
        {
            return (netIncome * 0.08) - eduExpenses - metroTax - waterTax - powerTax;
        }
    }
}
