using System;

namespace CS_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMO Interface");
            // lets define class instance
            // the 'math' has an access of all public methods 
            // of ClsMath class
            ClsMath math = new ClsMath();
            Console.WriteLine($"Add = {math.Add(20,30)}");
            Console.WriteLine($"Power = {math.Power(20, 5)}");
            Console.WriteLine($"Muliply = {math.Mumtiply(20, 5)}");
            // Since ClsMath impements IMath, its instace can also be created using Interface reference
            IMath m1 = new ClsMath();
            Console.WriteLine($"Interface Add = {m1.Add(20, 30)}");
            Console.WriteLine($"Interface Power = {m1.Power(20, 5)}");

            ClsMathNusense obj = new ClsMathNusense();

            IMath m2 = new ClsMathNusense();

            //Polymorphism using Interfaces

            Console.WriteLine($"IMath Add = {m2.Add(3,4)}");
            Console.WriteLine($"IMath Power = {m2.Power(3, 4)}");

            INewMath m3 = new ClsMathNusense();
            Console.WriteLine($"INewMath Add = {m3.Add(30, 4)}");
            Console.WriteLine($"INewMath Power = {m3.Power(4,6)}");


            Console.ReadLine(); 
        }
    }

    /// <summary>
    /// Interface is always public to assembly
    /// Interface members uses access specifier of the interace e.g. public
    /// </summary>
    public interface IMath
    {
        int Add(int x, int y);
        double Power(int x, int y);
    }

    public interface INewMath
    {
        int Add(int x, int y);
        double Power(int x, int y);
    }

    /// <summary>
    /// Class is Implementing the interface 'IMPLICITLY'
    /// Methods are declared by interface but they are owen by class
    /// </summary>
    public class ClsMath : IMath
    {
        public int Add(int x, int y)
        { 
            return (x*x) + (y*y);
        }
        public double Power(int x,int y)
        {
            return Math.Pow(x, y);
        }

        public int Mumtiply(int x, int y)
        {
             return (x * x) * (y * y); 
        }
    }

    /// <summary>
    /// Class can implement Multiple Interfaces, but if these interfaces has same methods with same
    /// signeture, then make sure tat class implement interface expliitly
    /// In this case Methods are accessible only using Interace reference
    /// </summary>
    public class ClsMathNusense : IMath, INewMath
    {
        int IMath.Add(int x, int y)
        {
            return (x * x) + (y * y);
        }

        int INewMath.Add(int x, int y)
        {
            return (x * x) + 2*x*y + (y * y);
        }

        double IMath.Power(int x, int y)
        {
            return Math.Pow(x, y);
        }

        double INewMath.Power(int x, int y)
        {
            return Math.Pow(y,x);
        }
    }
}
