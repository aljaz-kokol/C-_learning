using System;

namespace C03_Multi_Dimensional_Array
{
    class Program
    {
        public static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("[ ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("   [ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + (j < matrix.GetLength(1) - 1 ? ", " : " "));
                }
                Console.WriteLine("]" + (i < matrix.GetLength(0) - 1 ? ", " : " "));
            }

            Console.WriteLine("]");
        }

        public static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;
            // declare 3D array
            int[,,] matrix3D;
            // 2D array
            int[,] array2D = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine($"Number of dimensions: {array2D.Rank}");
            
            PrintMatrix(array2D);
        }
    }
}