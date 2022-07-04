using System;

namespace C04_Nested_For_Loop
{
    class Program
    {
        private static int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        
        public static void Main(string[] args)
        {
            foreach (int num in matrix)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n---------------------------------------------------------------");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}