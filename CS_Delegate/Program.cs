using System;
using System.Threading;
namespace CS_Delegate
{
    /// <summary>
    /// The delegate will be used to execute a method tat has
    /// 2 integer input parameters
    /// and integer as output parameter
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public delegate int OperationHandler(int x,int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Delegate");
            Console.WriteLine("Traditional Method call");
            int res = Add(10,20);
            Console.WriteLine($"Direct call to the Add() method = {res}");
            Console.WriteLine();
            Console.WriteLine("Using Delegate");
            // 1. CReate a delegate type instace (System.Delegate) and pass address of the method
            // to be invoked  it
            OperationHandler handler = new OperationHandler(Add);
            // 2. Pass input parameters to the delegate type instance
            // This will internall invoke the method
            int res1 = handler.Invoke(30, 40);  // explicit use of 'Invoke()' method
            Console.WriteLine($"C# 1.x Using Delegate to call method = {res1}");
            int res2 = handler(80, 90); // Impliit use of 'Invoke()' method
            Console.WriteLine($"C# 1.x Using Delegate to call method = {res2}");
            Console.WriteLine();
            Console.WriteLine("C# 2.0 Anynymous Type");
            // the Delegate contains the Implementation inside it
            // Anonymous Method
            OperationHandler handler1 = delegate (int x, int y) { return x + y; };
            Console.WriteLine($"Anonymous Method = {handler1(300,400)}");

            Console.WriteLine();
            Console.WriteLine("Passing a delegate to the method");
            PrintResult(handler1);
            Console.WriteLine();
            // if a method accept delegate as input parameter, then we can pass
            // the anonymous method implementation as input parameter to the method  
            Console.WriteLine("C# 2.0+ PAssing an Implementation as input parameter to a metho whihc accepts delegate SO called Easy Syntax ");
            PrintResult(delegate(int x,int y) { return x * y; });
            Console.WriteLine();
            Console.WriteLine($"C# 3.0, replace the delegate input parameter implementatio using Easy to wtite Lambda Expression");
            PrintResult((x, y) => { return x - y; });
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
          //  Thread.Sleep(3000); // Sleep the call for 3 seconds
            return x + y;
        }
        /// <summary>
        /// The Method with delegate as input parameter
        /// </summary>
        /// <param name="d"></param>
        static void PrintResult(OperationHandler d)
        {
            // use the delegate
            Console.WriteLine($"Result = {d(890,110)}");
        }
    }
}
