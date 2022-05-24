using System;

namespace CS_Events
{
    // 1. Declarae Delegate, this will be havig return type as 'void'
    public delegate void TransactionHandler(double tramount);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Event Demo");
            Banking bank = new Banking(50000);
            // Subscribe to the EvemtListener
            EventListener listener = new EventListener(bank);
            bank.Deposit(20000);
            Console.WriteLine($"After Deposit NetBalance  = {bank.GetNetBalance()}");
            bank.Withdraw(8000);
            Console.WriteLine($"After Withdraw NetBalance  = {bank.GetNetBalance()}");
            Console.ReadLine(); 
        }
    }


    public class Banking
    {
        private double NetBalance = 0;

        // 2. DEfine events
        public event TransactionHandler OverBalance;
        public event TransactionHandler UnderBalance;

        public Banking(double netBalance)
        {
            NetBalance = netBalance;
        }

        public void Deposit(double amount)
        {
            NetBalance += amount;
            // 3. Raise an event
            if (NetBalance >= 100000)
            {
                // Raise and Notify with Data
                // THis data is knows as 'Event Arguments' aka 'Payload'
                OverBalance(NetBalance);
            }
        }
        public void Withdraw(double amount)
        {
            // 3. Raise an Event
            NetBalance -= amount;
            if (NetBalance < 5000)
            {
                UnderBalance(NetBalance);
            }
        }
        public double GetNetBalance()
        {
            return NetBalance;
        }
    }

    /// <summary>
    /// 4. The class that will listen the event that is raised
    /// THis class will have parameterized COnstructor that accepts 
    /// an instance of class which raise event
    /// </summary>
    public class EventListener
    {
        Banking bank;

        public EventListener(Banking b)
        {
            this.bank = b;

            // Write a logic to generate notification based on event
            // Link Event to method, so that when an event is raise, the method
            // will be executed

            bank.OverBalance += Bank_OverBalance;
            bank.UnderBalance += Bank_UnderBalance;
        }

        private void Bank_UnderBalance(double tramount)
        {
            Console.WriteLine($"Dear Sir, your NetBalance is Rs {tramount}, whih less than Rs 5000, so please maintain minimum balance else the account will be blocked.");
        }

        private void Bank_OverBalance(double tramount)
        {
            double TaxableAmout = tramount - 100000;
            double Tax = TaxableAmout * 0.03;
            Console.WriteLine($"Dear Sir, you NetBanlance os Rs. {tramount} which is Rs.{TaxableAmout} more so please pat Tax of Rs. {Tax} else I-T will Raid you.");
        }
    }
}
