using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort
{
    public class RelativeSortArray
    {
        // need to look at counting sort
        public int[] RelativeSortArrayFunction(int[] arr1, int[] arr2)
        {
            int[] ans = new int[arr1.Length];
            int index = 0;
            HashSet<int> temp = new HashSet<int>();
            for (int n = 0; n < arr2.Length; n++)
            {
                temp.Add(arr2[n]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[j] == arr2[i])
                    {
                        ans[index] = arr1[j];
                        index++;
                    }

                }
                temp.Remove(arr2[i]);
            }
              Array.Sort(arr1);
                //for (int m = 0; m < arr1.Length; m++)
                //{
                //    if (!temp.Contains(arr1[m]))
                //    {
                //        ans[index] = arr1[m];
                //        index++;
                //    }

                //}
            
            return ans;
        }
    }
}
