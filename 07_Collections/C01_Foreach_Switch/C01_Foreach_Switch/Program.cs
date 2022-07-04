using System;

namespace C01_Foreach_Switch
{
    class Program
    {
        static bool IsAllAlphabetic(string inputValue)
        {
            foreach (char val in inputValue)
            {
                if (!char.IsLetter(val))
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            string inputValueType = string.Empty;
            bool valid = false;
            
            Console.Write("Enter a value: ");
            string inputValue = Console.ReadLine();
            
            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");
            
            Console.Write("Enter: ");
            int inputType = Convert.ToInt32(Console.ReadLine()); // in case of null or error Convert returns a 0

            switch (inputType)
            {
                case 1:
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int intValue = 0;
                    valid = int.TryParse(inputValue, out intValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool boolValue = false;
                    valid = bool.TryParse(inputValue, out boolValue);
                    inputValueType = "Boolean";
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }

            Console.WriteLine($"You have entered {inputValue}");
            if (valid)
            {
                Console.WriteLine($"It is valid: {inputValueType}");
            }
            else
            {
                Console.WriteLine($"It is invalid: {inputValueType}");
            }
        }
        
    }
}