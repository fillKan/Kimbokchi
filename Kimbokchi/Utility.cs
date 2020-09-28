using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kimbokchi
{
    public static class Utility
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

        public static int LuckyNumber(params float[] probablities)
        {
            float sum = 0f;

            float lucky = (float)new Random().NextDouble();

            for (int i = 0; i < probablities.Length; ++i)
            {
                sum += probablities[i];

                if (lucky <= sum) return i;
            }
            return -1;
        }

        public static int[] LuckyNumbers(int count, in float[] probablities)
        {
            var ramdom = new Random();

            int[] lucky = new int[count];

            var _probablities = probablities.ToList();

            for (int i = 0; i < count; ++i)
            {
                float sum = 0f;

                float probablity = (float)ramdom.NextDouble();

                for (int j = 0; j < _probablities.Count; ++j)
                {
                    if (probablity <= (sum += _probablities[j]))
                    {
                        float average = 
                            _probablities[lucky[i] = j] / (_probablities.Count - i - 1);

                        _probablities[j] = 0f;

                        for (int k = 0; k < _probablities.Count; k++)
                        {
                            if (_probablities[k] > 0f) {
                                _probablities[k] += average;
                            }
                        }
                        break;
                    }
                }
                if (!_probablities.Any(o => o > 0))
                {
                    _probablities = probablities.ToList();
                }
            }
            return lucky;
        }
    }
}
