using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.PrefixSum
{
    public class CheckifAlltheIntegersinaRangeAreCovered
    {
        public bool IsCovered(int[][] ranges, int left, int right)
        {
            int n = 52;
            int[] arr = new int[n];
            int[] prefix = new int[n];
            for (int i = 0; i < ranges.Length; i++)
            {
                arr[ranges[i][0]] += 1;
                arr[ranges[i][1]] -= 1;
            }
            prefix[0] = arr[0];
            for (int i = 1; i < n; i++)
            {
                prefix[i] += prefix[i - 1] + arr[i];
            }
            for (int i = left; i <= right; i++)
            {
                if (prefix[i] < 1)
                {
                    return false;
                }
            }
            return true;

        }

    
            public bool IsCovered2(int[][] ranges, int left, int right)
            {
                bool[] avaRange = new bool[51];
                for (int i = 0; i < ranges.Length; i++)
                {
                    for (int j = ranges[i][0]; j <= ranges[i][1]; j++)
                    {
                        avaRange[j] = true;
                    }
                }

                for (int i = left; i <= right; i++)
                {
                    if (!avaRange[i])
                        return false;
                }

                return true;
            }
    }
}

