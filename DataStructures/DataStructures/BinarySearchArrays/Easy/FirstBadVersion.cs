using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchArrays.Easy
{
    public class FirstBadVersion
    {
        public int FirstBadVersion1(int n)
        {
            int low = 0; int high = n;
            int ans = 0;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (IsBadVersion(mid) == false) 
                {
                    low = mid + 1;
                }
                else if (IsBadVersion(mid))
                {
                    ans = mid;
                    high = mid - 1;
                }

                /* more efficient way of writing
                 * if(IsBadVersion(mid))
            {
                 ans = mid;
                high = mid-1;
               
            }
            else 
            {
                low = mid +1;
            }
*/
                 
            }

            return ans;
        }
        // this will be provided by Leetcode. This is return only to make your code work
        public bool IsBadVersion(int num)
        {
            return true;
        }
    }
}
