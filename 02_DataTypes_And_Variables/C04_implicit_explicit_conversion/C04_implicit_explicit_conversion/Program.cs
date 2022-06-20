using System;

namespace C04_implicit_explicit_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // explicit conversion
            double myDouble = 13.37;
            int myInt = (int)myDouble;

            // implicit conversion
            int num = 1234567890;
            long bitNum = num;

            // typeConversion
            float myFloat = 13.37f;
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();
            
            // parseing from string
            string intString = "10";
            string intString2 = "5";
            int result = (int)Double.Parse(intString) + Int16.Parse(intString2);
            
            
            // Assignment
            string stringForFloat = "0,5"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float floatFromString = float.Parse(stringForFloat);
            int intFromString = int.Parse(stringForInt);

            Console.WriteLine(floatFromString);
            Console.WriteLine(intFromString);
            
        }
    }
}