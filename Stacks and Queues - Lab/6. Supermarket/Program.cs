using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> names = new Queue<string>();

            while (input!="End")
            {

                if (input=="Paid")
                {
                    int count = names.Count;
                    for (int i = 0; i < count; i++)
                    {
                        string name = names.Dequeue();
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    names.Enqueue(input);
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
