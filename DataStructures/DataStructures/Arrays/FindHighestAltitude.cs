using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class FindHighestAltitude
    {
        public int LargestAltitude(int[] gain)
        {
            int[] result = new int[gain.Length + 1];
            result[0] = 0;
            int max = int.MinValue;
            for (int i = 0; i < gain.Length; i++)
            {
                result[i+1] = gain[i] + result[i];
                max = Math.Max(max, result[i]);
            }
            max = Math.Max(max, result[gain.Length]);
            return max;
        }
        // Prefix sum
        public int LargestAltitude1(int[] gain)
        {
            // Initialize variables to store the maximum altitude and the current cumulative sum.
            int maxAlt = 0;
            int sum = 0;

            // Iterate through the 'gain' array.
            for (int i = 0; i < gain.Length; i++)
            {
                // Add the current gain to the cumulative sum.
                sum += gain[i];

                // Update the maximum altitude so far by taking the maximum of the current sum and the previous maximum altitude.
                maxAlt = Math.Max(sum, maxAlt);
            }

            // Return the maximum altitude reached.
            return maxAlt;
        }
    }
}
