using System;

namespace C01_String_and_its_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            Console.Write("Please enter your name and press enter: ");
            fullName = Console.ReadLine();

            Console.WriteLine($"Uppercase: {fullName.ToUpper()}");
            Console.WriteLine($"Lowercase: {fullName.ToLower()}");
            Console.WriteLine($"Trimmed: {fullName.Trim()}");
            Console.WriteLine($"Substring (2, 3): {fullName.Substring(2, 3)}");
        }
    }
}