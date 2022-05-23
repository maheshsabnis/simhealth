using System;

namespace CS_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Overloading as a Concept");

            OverloadedMethods methods = new OverloadedMethods();
            Console.WriteLine($"2 ints = {methods.Process(20,2)}");
            Console.WriteLine($"3 ints = {methods.Process(20, 2,1000)}");
            Console.WriteLine($"2 strings = {methods.Process("James", "Bond")}");
            Console.WriteLine($"Ftrst int and Second String = {methods.Process(007, "James")}");
            Console.WriteLine($"Ftrst string and Second int = {methods.Process("JAmes Bond", 007)}");
            Console.ReadLine();
        }
    }

    public class OverloadedMethods
    {
        public double Process(int x, int y)
        {
            return Math.Pow(x, y);
        }
        /// <summary>
        /// Different number of parameters of same type
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public double Process(int x, int y, int z)
        {
            return Math.Pow(x, y) + z;
        }
        /// <summary>
        /// Different TYpe of Parameters with same numbers of parameters
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public string Process(string x, string y)
        {
            return String.Concat(x,y);
        }
        /// <summary>
        /// Different Order of Parameters with same numbers of parameters
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public string Process(int x, string y)
        {
            return String.Concat(x.ToString(), y);
        }

        /// <summary>
        /// same numbers of parameters with same types but diffeenet in order
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public string Process(string x, int y)
        {
            return String.Concat(x, y.ToString());
        }

        
    }
}
