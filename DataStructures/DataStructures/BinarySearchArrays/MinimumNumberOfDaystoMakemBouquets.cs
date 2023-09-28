using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays
{
   public class MinimumNumberOfDaystoMakemBouquets
    {
        // Brute force
        public int MinDays(int[] bloomDay, int m, int k)
        {
            int min = bloomDay.Min();
            int max = bloomDay.Max();
            int numofelements = bloomDay.Length;
            if (m * k > numofelements) return -1;
            // you know for sure that the answer lies between min and max days of array

            for( int i = min; i<= max; i++)
            {
                if (Possible(bloomDay, i, m, k)) return i;
               
            }

            return -1;
        }

        public bool Possible(int[] bloomDay, int day, int m, int k)
        {
            int numberofBookays = 0;
            int count = 0;
            for(int i=0; i< bloomDay.Length; i++)
            {
                if(bloomDay[i] <= day)
                {
                    count++;
                }
                else 
                {
                    numberofBookays += count / k;
                    count = 0;
                }
            }
            numberofBookays += count/k; // you need to check again at the end of the array

            if (numberofBookays >= m) return true;
            else return false;


        }
        // Using Binary Searc
        public int MinDays2(int[] bloomDay, int m, int k)
        {
            int low = bloomDay.Min();
            int high = bloomDay.Max();
            int numofelements = bloomDay.Length;
            if (m * k > numofelements) return -1;
            // you know for sure that the answer lies between min and max days of array
            int ans = -1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (Possible(bloomDay, mid, m, k))
                {
                    ans = mid; // this a possible ans but is it the lowest? Hence we search more.
                    high = mid - 1;
                }
                else low = mid + 1;
            }

            return ans;
        }
    }
}
