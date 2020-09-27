using System;
using System.Collections.Generic;
using System.Text;

namespace Kimbokchi
{
    public static class Utitity
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a; a = b; b = temp;
        }
    }
}
