using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();

            int numTemp = 0;
            if (int.TryParse(temperature, out numTemp))
            {
                if (numTemp < 20)
                {
                    Console.WriteLine("Take the coat");
                } else if (numTemp == 20)
                {
                    Console.WriteLine("Pants and Pull Over should be fine");
                } else if (numTemp > 30)
                {
                    Console.WriteLine("It's super hot!");
                } else
                {
                    Console.WriteLine("Shorts are enough today");
                }
            }
        }
    }
}