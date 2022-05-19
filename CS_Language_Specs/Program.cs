// Top Level NAmespace
using System;

namespace CS_Language_Specs
{
    /// <summary>
    /// The Main ENrty Point to App
    /// Ll Methods of the Program class will be static
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry Point Method
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Output Statement
            // Console is a class under System NAmespace
            Console.WriteLine("Hello World!");
            int x = 0, y = 0, z = 0;
            Console.WriteLine("Enter value for x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y");
            //y = Convert.ToInt32(Console.ReadLine());
            var value = Console.ReadLine();
            if (value.GetType() == typeof(string))
            {
                y = 0;
            }


            //z = x + y;
            //// "z = ", is a String
            //// + is the operator which is overloade for String Conctenation
            //Console.WriteLine("z = " + z);

            // call the method
            DisplayMessage();
            // Call method with Retun value
            // x and y are actua parameters
            z = Add(x, y);
            Console.WriteLine("z = " + z);
            // Input Statement, waits for the input from the console
            Console.ReadLine();
        }

        /// <summary>
        /// method w/o any inut and output parameter
        /// </summary>
        static void DisplayMessage()
        {
            Console.WriteLine("Display Message Methd called");
        }
        /// <summary>
        /// x and y are Formal Parameters
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int Add(int x, int y)
        {
            // Implicit Return
            return x + y;
        }
         
    }
}
