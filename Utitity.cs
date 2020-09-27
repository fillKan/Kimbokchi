using System;
using System.Collections.Generic;
using System.Text;

namespace Kimbokchi
{
    public static class Utitity
    {
        public static void Swap<T>(T a, T b)
        {
            T temp = a; a = b; b = temp;
        }
    }
}
