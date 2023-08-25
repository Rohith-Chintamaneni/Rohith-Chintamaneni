using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://leetcode.com/problems/car-pooling/
namespace DataStructures.Arrays.PrefixSum
{
    public class Carpooling
    {
        // Process all trip by adding passengers and removing them at a particular time. Finally positive tells the num of passengers and -negative tells the vacant positions. 
        // At any point if it is more than capacity you flag
        public bool CarPooling(int[][] trips, int capacity)
        {
            int[] occupancies = new int[1001];

            foreach (int[] trip in trips)
            {
                occupancies[trip[1]] += trip[0];
                occupancies[trip[2]] -= trip[0];
            }

            int prefixSum = 0;

            foreach (int occupancy in occupancies)
            {
                prefixSum += occupancy;

                if (prefixSum > capacity)
                    return false;
            }

            return true;

        }
        public bool CheckOverlap(int[] i1, int[] i2)
        {
            if (i2[1] < i1[2])
            {
                i2[1] = i1[2];
                return true;
            }
            return false;

        }

    }
}
