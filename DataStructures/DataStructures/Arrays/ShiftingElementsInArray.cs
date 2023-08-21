using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class ShiftingElementsInArray
    {
        public int[] ShiftToLeft(int[] arr, int k)
        {
            for(int i=0; i<k; i++)
            {
                for(int j=0; j< arr.Length-1; j++)
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }

            }

            return arr;
        }
    }
}
