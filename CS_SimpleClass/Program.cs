using System;
// importing the namespace
using CS_OtherNamecpace;
using CS_SimpleClass.CS_SimpleClass;
namespace CS_SimpleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple OOPs");
            // Lets Instantiate the class
            ClsMath math = new ClsMath(); // defining the reference

            // Lets Invoke methods of ClsMasth class

            int rAdd = math.Add(10, 0);
            Console.WriteLine($"Add = {rAdd}");

            int rSub = math.Subsct(10, 0);
            Console.WriteLine($"Add = {rSub}");

            int rSquare = math.Square(0);
            Console.WriteLine($"Add = {rSquare}");

            int rMulti = math.Multi(10, 0);
            Console.WriteLine($"Add = {rMulti}");

            int rDiv = math.Division(100, 0);
            Console.WriteLine($"Add = {rDiv}");

            StringOperations op1 = new StringOperations();

            StringOperations op2 = new StringOperations("James Bond");

            Messaging msg = new Messaging();

            MessagingNew msgnew = new MessagingNew();

            MyClass m = new MyClass();


            Console.ReadLine();
        }
    }

    public class ClsMath
    {
        /// <summary>
        /// Private method which will be limited to the class
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool Validate(int x, int y)
        {
            if(x == 0 || y ==0)
                return false;
            else 
                return true;
        }
        public int Add(int x, int y)
        {
             
            return x + y;
        }
        public int Subsct(int x, int y)
        {
             
            return x - y;
        }
        public int Square(int x)
        {
            // if Validate() return false the return 0
            if (!Validate(x,0)) return 0;
            return x * x;
        }

        public int Multi(int x, int y)
        {
            // if Validate() return false the return 0
            if (!Validate(x, y)) return 0;
            return x * y;
        }
        public int Division(int x, int y)
        {
            // if Validate() return false the return 0
            if (!Validate(x, y)) return 0;
            return x / y;
        }

    }

    class StringOperations
    {
        // default access specifier is private for each
        // class member of the class if not speified explicitly 
        string _str;

        public StringOperations()
        {
            Console.WriteLine("Default Ctor is called");
        }
        /// <summary>
        /// Overloaded COnstructor
        /// </summary>
        /// <param name="str"></param>
        public StringOperations(string str)
        {
            _str = str;
            Console.WriteLine($"Overloaded ctor is called {_str}");
        }
    }
}
