using System;

namespace C02_Arrays
{
    class Program
    {
        public static void PritnArray(int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ((i < array.Length - 1) ? ", " : " "));
            }
            Console.WriteLine("]");
        }

        public static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;
            PritnArray(grades);

            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };
            PritnArray(gradesOfMathStudentsA);
            
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 16 };
            PritnArray(gradesOfMathStudentsB);
        }
    }
}