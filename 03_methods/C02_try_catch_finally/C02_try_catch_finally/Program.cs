using System;

namespace C02_try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            try
            {
                int userInputAsInt = int.Parse(Console.ReadLine());
                Console.WriteLine(userInputAsInt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Format exception please enter the correct type next time");
            }
            finally
            {
                Console.WriteLine("This will get called no matter what");
            }
        }
    }
}