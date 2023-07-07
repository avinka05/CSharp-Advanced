﻿using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

           

            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            bool found = false;
            int foundRow = -1;
            int foundCol = -1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        found = true;
                        foundRow = i;
                        foundCol = j;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"({foundRow}, {foundCol})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
