using System;
using System.Collections.Generic;

namespace Kimbokchi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 60% : 0, 
            // 30% : 1, 
            //  5% : 2, 
            //  3% : 3, 
            //  2% : 4
            float[] probabilities = new float[5] { 0.6f, 0.3f, 0.05f, 0.03f, 0.02f };

            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"{Utitity.LuckyNumber(probabilities)}");
            }
            Console.ReadLine();
        }
    }
}
