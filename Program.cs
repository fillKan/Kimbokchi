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


            Console.WriteLine("Before Selection Sort : ");
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next());
                Console.WriteLine($"{list[i]}");
            }

            Console.WriteLine("After Selection Sort : ");
            list.SelectionSort((a, b) => b > a);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i]}");
            }
            Console.ReadLine();
        }
    }
}
