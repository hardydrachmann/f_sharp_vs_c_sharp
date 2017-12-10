using System;
using System.Collections.Generic;

namespace Logic_cSharp
{
    public class Clogic
    {
        public static List<int> Sort(List<int> list)
        {
            Quicksort(list.ToArray(), 0, list.Count - 1);
            return list;
        }

        private static void Quicksort(int[] list, int left, int right)
        {
            int i = left, j = right;
            int pivot = list[(left + right) / 2];
            while (i <= j)
            {
                while (list[i].CompareTo(pivot) < 0)
                    i++;
                while (list[j].CompareTo(pivot) > 0)
                    j--;
                if (i <= j)
                {
                    // Swap
                    int tmp = list[i];
                    list[i] = list[j];
                    list[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
                Quicksort(list, left, j);
            if (i < right)
                Quicksort(list, i, right);
        }

        public static List<int> Reverse(List<int> list)
        {
            int[] array = new int[list.Count];
            int i = array.Length - 1;
            foreach (int val in list)
                array[i--] = val;

            return new List<int>(array);
        }

        public static int Calculate(List<int> list)
        {
            int result = 0;
            foreach (int i in list)
                result += i;

            return result;
        }

    }
}
