using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class ProductExceptSelf
    {
        //calculate the product of when it is zero. Use that for that index which is equal to 0,rest all you can do it by calculating division and modulo..
        public int[] ProductExceptSelfArray(int[] nums)
        {
            int product = 1;
            int[] ans = new int[nums.Length];
            int zerocount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) zerocount++;
            }
            if (zerocount > 1) return ans;
            int productofZeroIndex = 1;
            //int rightprod = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    continue;
                else
                    productofZeroIndex = productofZeroIndex * nums[i];
            }

            //for (int i = nums.Length - 1; i > 0; i--)
            //{
            //    if (nums[i] == 0)
            //        break;
            //    else
            //        rightprod = rightprod * nums[i];
            //}
            //int total = leftprod * rightprod;

            for (int i = 1; i < nums.Length; i++)
            {
                product = product * nums[i];
            }
            ans[0] = product;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    product = product / nums[i];
                    product = product * nums[i - 1];
                    ans[i] = product;
                }
                else
                    ans[i] = productofZeroIndex;
            }


            return ans;

        }

        // Using Prefix and suffix 
         public int[] productExceptSelf2(int[] nums)
            {
                int n = nums.Length;
                int[] pre = new int[n];
                int[] suff = new int[n];
                pre[0] = 1;
                suff[n - 1] = 1;

                for (int i = 1; i < n; i++)
                {
                    pre[i] = pre[i - 1] * nums[i - 1];
                }
                for (int i = n - 2; i >= 0; i--)
                {
                    suff[i] = suff[i + 1] * nums[i + 1];
                }

                int[] ans = new int[n];
                for (int i = 0; i < n; i++)
                {
                    ans[i] = pre[i] * suff[i];
                }
                return ans;
            }
        // IMproved one with Single array.
        public int[] productExceptSelf3(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n];
            Array.Fill(ans, 1);
            int curr = 1;
            for (int i = 0; i < n; i++)
            {
                ans[i] *= curr;
                curr *= nums[i];
            }
            curr = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                ans[i] *= curr;
                curr *= nums[i];
            }
            return ans;

        }

    }
}
