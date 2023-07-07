using System;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());



            int[,] matrix = new int[rows, rows];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(' ');

                for (int col = 0; col < rows; col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] commandData = command.Split(' ');

                string action = commandData[0];
                int row = int.Parse(commandData[1]);
                int col = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);

                if (row < 0 || row >= rows || col < 0 || col >= rows)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (action == "Add")
                {
                    matrix[row, col] += value;
                }
                else if (action == "Subtract")
                {
                    matrix[row, col] -= value;
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}