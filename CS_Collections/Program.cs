using System;
using System.Collections;
namespace CS_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarae a Array
            int[] intArr = new int[5];
            Console.WriteLine("Enter Array Value");
            for (int i = 0; i < intArr.Length; i++)
            {
                int v = Convert.ToInt32(Console.ReadLine());
                intArr[i] = v;
            }
            Console.WriteLine();
            Console.WriteLine("Values in Array");
            for (int i = 0; i < intArr.Length; i++)
            {
                // Console.WriteLine("Value at \n" + i + "  = " + intArr[i]);
                // String Interpolation
                Console.WriteLine($"Value at {i}" +
                    $" \n = {intArr[i]} ");
            }
            Console.ReadLine();
        }
    }
}
