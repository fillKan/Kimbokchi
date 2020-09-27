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

        public static void Swap<T>(this T[] array, int indexA, int indexB)
        {
            T temp = array[indexA]; array[indexA] = array[indexB]; array[indexB] = temp;
        }

        public static void Swap<T>(this List<T> list, int indexA, int indexB)
        {
            T temp = list[indexA]; list[indexA] = list[indexB]; list[indexB] = temp;
        }
    }
}
