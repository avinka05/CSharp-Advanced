using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbersQueue = new Queue<int>(array);

            List<int> evenNumbers = new List<int>();

            while (numbersQueue.Count > 0)
            {
                int number = numbersQueue.Dequeue();

                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            string evenNumbersString = string.Join(", ", evenNumbers);
            Console.WriteLine(evenNumbersString);
        }
    }
}
