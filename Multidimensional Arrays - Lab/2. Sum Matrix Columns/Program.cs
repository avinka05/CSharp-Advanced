using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];


            int result = 0;

            int[,] matrix = new int[rows, 

            for (int row = 0; row < rows; row++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            for ( int col = 0; col < cols; col++)
            {

                for (int row = 0; row < rows; row++)
                {
                    result += matrix[row, col];
                }
                
                Console.WriteLine(result);
                result = 0;
            }
        }
    }
}
