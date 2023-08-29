using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.PrefixSum
{
   public class SubarraySumDivisibleByK
    {
        public int SubarraysDivByK(int[] nums, int k)
        {
            Dictionary<int, int> prefix = new Dictionary<int, int>();
            prefix.Add(0, 1);
            int count = 0;
            int sum = 0;
            int remainder = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                remainder = sum % k;
                if (remainder < 0) remainder += k; // to handle negative remainder, we need to convert to positive
                if (prefix.ContainsKey(remainder))
                {
                    count = count + prefix[remainder];

                }
                if (!prefix.ContainsKey(remainder))
                {
                    prefix[remainder] = 0;
                }
               
                    prefix[remainder]++;
                
               


            }
            return count;
        }
    }
}
