using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort
{
    class SelectionSort
    {
        public int[] SelectionSorting(int[] num)
        {
            int minindex = 0;
            for (int i = 0; i < num.Length-1; i++)
            {
                minindex = i;
                for (int j = i+1; j < num.Length; j++)
                {
                    if (num[j] < num[minindex]) minindex = j;
                }

                Swap(num, i, minindex);
            }


            return num;
        }

        private void Swap(int[] num, int i, int minindex)
        {
            var temp = num[i];
            num[i] = num[minindex];
            num[minindex] = temp;
        }
    }
}
