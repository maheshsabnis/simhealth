using System;

namespace CS_Shadowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shadowing");
            Base b = new Base();
            b.m1("Tejas", "Sabnis");
            Derive d = new Derive();
            d.m1("MAhesh", "Sabnis");

            // reference of Base istantiated using Derive
            b = new Derive(); // Upcasting
            b.m1("Indiana", "Jones"); // Call BAse Class Method

            // Casting the DErive class Reference to DErive class but instantiate it using Base class

            d = (Derive)new Base(); // Downcasting
            d.m1("Ethan", "Hunt"); // Runtime error



            Console.ReadLine(); 
        }
    }


    public class Base
    {
        public void m1(string x, string y)
        {
            Console.WriteLine($"Conact BAse { String.Concat(x,y)}");
        }
    }
    public class Derive : Base
    {
        /// <summary>
        /// Shadowing
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public new void m1(string x, string y)
        {
            Console.WriteLine($"Conact DErive{String.Concat(x, y)}");
        }
    }
}
