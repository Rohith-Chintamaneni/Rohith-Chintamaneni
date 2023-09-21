using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
    public class KokoEatingBanana
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int low = 1;
            int high = piles.Max();
            // the answer lies here between 1 and max of array. But we don't know which one, Hence we do BS on it.
            int ans = -1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                long hours = GetTotalHours(piles, mid);
                if (hours <= h)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {

                    low = mid + 1;
                }
            }
            return ans;
        }
        public long GetTotalHours(int[] piles, long hourly)
        {
            long totalhours = 0;
            for (int i = 0; i < piles.Length; i++)
            {
                totalhours += (long)Math.Ceiling((double)piles[i] / hourly);
            }
            return totalhours;
        }
    }
}
