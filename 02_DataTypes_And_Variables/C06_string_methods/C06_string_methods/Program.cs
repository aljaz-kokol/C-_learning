using System;

namespace C06_string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Denis";
            string lastName = "Panjuta";
            string fullName = $"   {firstName} {lastName}   ";
            
            Console.WriteLine(firstName.Substring(2)); // "nis"
            Console.WriteLine(firstName.ToLower()); // "denis"
            Console.WriteLine(firstName.ToUpper()); // "DENIS"
            Console.WriteLine(fullName.Trim()); // "Denis Panjuta"
            Console.WriteLine(firstName.IndexOf('e')); // 1
            Console.WriteLine(String.IsNullOrWhiteSpace(firstName));
        }
    }
}