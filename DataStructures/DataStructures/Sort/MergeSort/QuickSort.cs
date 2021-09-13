using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Sort.MergeSort
{
    public class QuickSort
    {
        public int[] QuickSortImplementation(int[] numbers, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i] < pivot)
                    i++;

                while (numbers[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSortImplementation(numbers, left, j);

            if (i < right)
                QuickSortImplementation(numbers, i, right);

            return numbers;
        }


    }
}
