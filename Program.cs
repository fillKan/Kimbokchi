using System;
using System.Collections.Generic;

namespace Kimbokchi
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int[] array = new int[15];


            Console.WriteLine("Before MergeSort : ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
                Console.WriteLine($"{array[i]}");
            }

            Console.WriteLine("After MergeSort : ");
            Sort.MergeSort(array, (a, b) => b > a);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
            Console.ReadLine();
        }
    }
}
