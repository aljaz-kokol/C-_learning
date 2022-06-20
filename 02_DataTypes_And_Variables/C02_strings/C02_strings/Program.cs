using System;

namespace C02_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Aljaz";
            string message = "My name is " + myName;
            
            Console.WriteLine(myName);
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());
        }
   
    }
}