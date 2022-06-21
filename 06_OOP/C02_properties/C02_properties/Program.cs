using System;

namespace C02_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 4, 5);

            box.DisplayInfo();
            Console.WriteLine($"Volume is {box.Volume}");
            Console.WriteLine($"Front surface is {box.FrontSurface}");
        }
    }
}