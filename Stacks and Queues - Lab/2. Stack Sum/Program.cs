using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] array = command.Split();

                if (array[0] == "add")
                {
                    int[] n = array
                        .Skip(1)
                        .Select(int.Parse)
                        .ToArray();

                    foreach (var item in n)
                    {
                        numbers.Push(item);
                    }
                }
                else if (array[0] == "remove")
                {
                    int count = int.Parse(array[1]);

                    if (count <= numbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Sum: " + numbers.Sum());
        }
    }
}
