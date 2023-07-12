using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split().ToArray();
            
            
            Stack<string> expression = new Stack<string>(inputArray.Reverse());

            int result = int.Parse(expression.Pop());

            while (expression.Count>0)
            {
                string operation = expression.Pop();

                int number = int.Parse(expression.Pop());

                if (operation=="+")
                {
                    result += number;
                }
                else if (operation == "-")
                {
                    result -= number;
                }

            }
            Console.WriteLine(result);


        }
    }
}
