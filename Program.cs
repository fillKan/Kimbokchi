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

            int count0 = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            int[] luckyNumbers = Utility.LuckyNumbers(5, probabilities);

            for (int i = 0; i < 5; ++i)
            {
                switch (luckyNumbers[i])
                {
                    case 0: count0++;
                        break;
                    case 1: count1++;
                        break;
                    case 2: count2++;
                        break;
                    case 3: count3++;
                        break;
                    case 4: count4++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"60% : {count0}");
            Console.WriteLine($"30% : {count1}");
            Console.WriteLine($"05% : {count2}");
            Console.WriteLine($"03% : {count3}");
            Console.WriteLine($"02% : {count4}");

            Console.ReadLine();
        }
    }
}
