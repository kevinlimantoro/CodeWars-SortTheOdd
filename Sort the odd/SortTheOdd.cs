using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_the_odd
{
    public static class Kata
    {
        public static int[] SortArray(int[] array)
        {
            var sortOdd = new List<int>();
            foreach (int item in array)
            {
                if (item.IsValidOdd())
                    sortOdd.Add(item);
            }
            sortOdd.Sort();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].IsValidOdd())
                {
                    array[i] = sortOdd.First();
                    sortOdd.RemoveAt(0);
                }
            }
            return array;
        }

        public static bool IsValidOdd(this int input)
        {
            return input > 0 && input % 2 > 0;
        }
    }
}
