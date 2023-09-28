using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    public class CapacityToShipinDDays
    {
        public int ShipWithinDays(int[] weights, int days)
        {
            int low = weights.Max();
            int high = weights.Sum(); // it will be within the sum of array
            int ans = -1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (GetDaysByCapacity(weights, mid) <= days)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                    low = mid + 1;

            }


            return ans;
        }

        public int GetDaysByCapacity(int[] weights, int capacity)
        {
            int load = 0; int days = 1;
            for (int i = 0; i < weights.Length; i++)
            {
                if (load + weights[i] > capacity)
                {
                    days++;
                    load = weights[i];
                }
                else load += weights[i];

            }
            return days;
        }
    }
}
