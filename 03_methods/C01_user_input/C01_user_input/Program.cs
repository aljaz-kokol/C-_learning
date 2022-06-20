using System;

namespace C01_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Calculate());
        }

        public static int Calculate()
        {
            Console.Write("Please enter your first number: ");
            string num1Input = Console.ReadLine();

            Console.Write("Please enter your second number: ");
            string num2Input = Console.ReadLine();
            
            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);
            return num1 + num2;
            
        }
    }
}
