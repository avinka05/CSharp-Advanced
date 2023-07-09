using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> text = new Stack<char>(input);

            while (text.Any())
            {
                char result = text.Pop();
                Console.Write(result);
            }

        }
    }
}
