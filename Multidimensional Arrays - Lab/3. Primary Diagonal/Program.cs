using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int maxRow = 0;
            int maxCol = 0;

            int[,] matrix = new int[rows, cols];


            for (int row = 0; row < rows; row++)
            {
                int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            int maxSum = 0;


            for (int row = 0; row < rows-1; row++)
            {
               
                for (int col = 0; col < cols-1; col++)
                {
                   int currentSum = 0;
                    currentSum += matrix[row, col];
                    currentSum += matrix[row, col+1];
                    currentSum += matrix[row+1, col];
                    currentSum += matrix[row+1, col+1];

                    if (currentSum>maxSum)
                    {
                        maxRow = row;
                        maxCol = col;
                        maxSum = currentSum;
                    }

                }
            }
            Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow, maxCol+1]}");
            Console.WriteLine($"{matrix[maxRow+1, maxCol]} {matrix[maxRow + 1, maxCol+1]}");
            Console.WriteLine(maxSum);


        }
    }
}
