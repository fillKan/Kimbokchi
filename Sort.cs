using System;
using System.Collections.Generic;
using System.Text;

namespace Kimbokchi
{
    public static class Sort
    {
        public static void MergeSort<T>(T[] array, Func<T, T, bool> IsRValueBigger)
        {
            MergeSort(array, 0, array.Length - 1, new T[array.Length], IsRValueBigger);
        }

        public static void MergeSort<T>(T[] array, int min, int max, T[] tempArray, Func<T, T, bool> IsRValueBigger)
        {
            if (min >= max) return;

            int mid = (min + max) / 2;

            MergeSort(array, min,     mid, tempArray, IsRValueBigger);
            MergeSort(array, mid + 1, max, tempArray, IsRValueBigger);

            int i = min;
            int j = mid + 1;

            for (int k = min; k <= max; k++)
            {
                if (i > mid)
                {
                    tempArray[k] = array[j++];
                }
                else if (j > max)
                {
                    tempArray[k] = array[i++];
                }
                else if(IsRValueBigger(array[i], array[j]))
                {
                    tempArray[k] = array[i++];
                }
                else
                {
                    tempArray[k] = array[j++];
                }
            }
            for (i = min; i <= max; i++) array[i] = tempArray[i];
        }
    }
}
