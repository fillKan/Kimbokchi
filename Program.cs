using System;
using System.Collections.Generic;

public enum Items
{
    Iron, Bronze, Sliver, Gold, Diamond
}

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

            var luckyBox = new LuckyBox<Items>();

            luckyBox.AddItem(0.6f, Items.Iron, Items.Iron, Items.Iron, Items.Iron, Items.Iron);
            luckyBox.AddItem(0.3f, Items.Bronze, Items.Bronze, Items.Bronze, Items.Bronze);
            luckyBox.AddItem(0.05f, Items.Sliver, Items.Sliver, Items.Sliver);
            luckyBox.AddItem(0.03f, Items.Gold, Items.Gold);
            luckyBox.AddItem(0.02f, Items.Diamond);

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(luckyBox.RandomItem().ToString());

                if (i == 14) Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
