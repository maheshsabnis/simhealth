using System;

namespace CS_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Extension Method");
            string str = "My name is Mahesh Sabnis";
            Console.WriteLine($"Length of {str} is = {str.Length}");
            Console.WriteLine($"Upper case of {str} is = {str.ToUpper()}");
            Console.WriteLine($"Reverse of {str} is = {str.Reverse()}");

            ClsMath m = new ClsMath();
            Console.WriteLine($"Add  = {m.Add(20,30)}");
            Console.WriteLine($"Multiple = {m.Multiply(100,300)}");
            Console.ReadLine(); 
        }
    }

    public static class StringExtensions
    {
        /// <summary>
        /// THis is an extension method for STring class
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(this string str)
        {
            string reverse = String.Empty;
            for (int i = str.Length-1; i >= 0; i--)
            {
                reverse+=str[i];
            }
            return reverse;
        }
    }

    public sealed class ClsMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    public static class MathExtension
    {
        public static int Multiply(this ClsMath m, int a,int b)
        {
            return a * b;
        }
    }

}
