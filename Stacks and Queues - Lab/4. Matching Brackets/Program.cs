using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)           
            {
                if (expression[i]=='(')
                {
                    indexes.Push(i);
                    continue;
                }
                else if (expression[i] == ')')
                {
                    int opened = indexes.Pop();
                    for (int j = opened; j <= i; j++)
                    {
                        Console.Write(expression[j]);
                    }
                    Console.WriteLine();
                }


            }

        }
    }
}
