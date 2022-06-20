using System;

namespace C05_string_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 31;
            string name = "Alfosno";
            string job = "Developer";
            
            // 1. String concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old, I am currently employed as a " + job);
            
            // 2. String formatting
            Console.WriteLine("\nString Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old, I am currently employed as a {2}", name, age, job);
            
            // 3. String interpolation --> $"{varName}"
            Console.WriteLine("\nString Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old, I am currently employed as {job}"); 
            
            // 4. Verbatim string --> @"some string" takes the string literally with all spaces, new lines, tabs, ...
            Console.WriteLine("\nVerbatim Interpolation");
            Console.WriteLine(@"""his \n string will be
                
                   sdfsf

                        Taken literaly
            """);
        }
    }
}