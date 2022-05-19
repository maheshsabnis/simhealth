// Top Level NAmespace
using System;

namespace CS_Language_Specs
{
    /// <summary>
    /// The Main ENrty Point to App
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry Point Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Output Statement
            // Console is a class under System NAmespace
            Console.WriteLine("Hello World!");
            int x, y, z;
            Console.WriteLine("Enter value for x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            // "z = ", is a String
            // + is the operator which is overloade for String Conctenation
            Console.WriteLine("z = " + z);
            // Input Statement, waits for the input from the console
            Console.ReadLine();
        }

         
    }
}
