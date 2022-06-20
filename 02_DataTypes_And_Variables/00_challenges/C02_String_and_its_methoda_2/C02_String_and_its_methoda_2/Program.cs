using System;

namespace C02_String_and_its_methoda_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            Console.Write("Enter a string here: ");
            text = Console.ReadLine();
            
            Console.Write("Enter a char you are searching: ");
            char searchChar = Console.ReadLine()[0];
            
            Console.WriteLine($"\ntext: {text}\nsearching: {searchChar}");
            Console.WriteLine($"first appearance: {text.IndexOf(searchChar)}");

            string firstName;
            string lastName;

            Console.Write("\nEnter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine($"Your full name: {firstName} {lastName}");

        }
    }
}