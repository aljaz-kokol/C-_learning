using System;

namespace C01_vars_and_datatypes
{
    class Program
    {
        static void Main(String[] args)
        {
            int num1 = 7;
            int num2 = 15;
            int sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;

            Console.WriteLine(d1 + " / " + d2 + " = " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine(f1 + " / " + f2 + " = " + fDiv);
            byte a = 255;
            Console.WriteLine(a);
        }
    }
}
