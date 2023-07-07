using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int rows = int.Parse(Console.ReadLine());

            long[][] triangle = new long[rows][];

            for (int i = 0; i < rows; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][0] = 1;

                if (i > 0)
                {
                    triangle[i][i] = 1;

                    for (int j = 1; j < i; j++)
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }

            PrintPascalTriangle(triangle);
        }

        static void PrintPascalTriangle(long[][] triangle)
        {
            int rows = triangle.Length;

            for (int i = 0; i < rows; i++)
            {
                int cols = triangle[i].Length;

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
