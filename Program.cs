using System;
using System.Collections.Generic;

namespace Kimbokchi
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var list = new List<int>();
            var array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next();

                list.Add(random.Next());

                Console.WriteLine($"{array[i]}");
            }

            Console.WriteLine("");
            array.SelectionSort((a, b) => b > a);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
            Console.ReadLine();
        }
    }
}
