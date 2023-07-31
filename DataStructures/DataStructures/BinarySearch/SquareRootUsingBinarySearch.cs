using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearch
{
    public class SquareRootUsingBinarySearch
    {
        public float FindSquareRootSequential(int n)
        {
            int start = 1; 
            float ans= 1.0f, tempans=1.0f;
            while (start < n)
            {
                if (start * start == n)
                {
                    ans = start;
                    return ans;
                }
                if(start * start <= n)
                {
                    tempans = start;
                }
                start++;

            }
            float increment = 0.1f;

            for(int i =1; i<5; i++)            {
                
                while (tempans * tempans <= n)
                {
                    tempans = tempans + increment;
                }
                tempans = tempans - increment;
                increment = increment / 10;
            }

            ans = tempans;
            return ans;
        }

        public double FindSquareRootBinarySearch(int n)
        {
            int start = 0, end = n;

            double ans = 0;
            while (start < end)
            {
                int mid = (start + end) / 2;

                if (mid * mid == n)
                {
                    ans = start;
                    return ans;
                }
                if (mid * mid < n)
                {
                    start = mid + 1;
                    ans = mid;
                }
                else
                {
                    end = mid - 1;
                }
             

            }
            double increment = 0.1;

            for (int i = 1; i < 5; i++)
            {

                while (ans * ans <= n)
                {
                    ans = ans + increment;
                }
                ans = ans - increment;
                increment = increment / 10;
            }

           
            return ans;
        }
    }
}
