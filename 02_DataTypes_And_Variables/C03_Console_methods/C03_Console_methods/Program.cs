using System;
using System.Transactions;

namespace C03_Console_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            
            Console.Write("Enter a string and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII values is {0}", asciiValue);
        }
    }
}