using System;

namespace CS_ANonymous_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Types");
            var obj = new { Id=1, Name="Mahesh" };

            Console.WriteLine($"Id = {obj.Id} and Name = {obj.Name}");
            Console.ReadLine(); 
        }
    }
}
