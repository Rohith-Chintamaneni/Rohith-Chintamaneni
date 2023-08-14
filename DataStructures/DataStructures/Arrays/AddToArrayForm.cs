using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class AddToArrayForm
    {

        // Too Bad. It works but lot of logic, Which makes it hard.
        public IList<int> AddToArray(int[] num, int k)
        {
            List<int> result = new List<int>();
            int sum = 0;
            int remainder = 0;
            int carry = 0;
            int arrLength = num.Length;
            int numofDigits = (int)Math.Log10(k) + 1;
            int i = arrLength - 1;
            while (i >= 0 || numofDigits > 0)
            {
                if (i >= 0)
                    sum = num[i];

                remainder = k % 10;
                if (remainder > 0)
                    sum = sum + remainder;

                if (carry > 0)
                {
                    sum = sum + carry;
                    carry = 0;
                }
                if ((int)Math.Log10(sum) + 1 == 2)
                {
                    carry = 1;
                    sum = sum % 10;

                }
                result.Add(sum);
                sum = 0;
                k = k / 10;
                i--;
                numofDigits--;
            }


            //for (int i = num.Length - 1; i >= 0; i--)
            //{
            //    sum = num[i];
            //    remainder = k % 10;
            //    if (k > 0)
            //        sum = sum + remainder;

            //    if (carry > 0)
            //    {
            //        sum = sum + carry;
            //        carry = 0;
            //    }
            //    if ((int)Math.Log10(sum) + 1 == 2)
            //    {
            //        carry = 1;
            //        sum = sum % 10;

            //    }
            //    result.Add(sum);
            //    k = k / 10;
            //}

            //while (k > 0)
            //{
            //    remainder = k % 10;
            //    if(carry > 0)
            //    {
            //        remainder = remainder + carry;
            //        if ((int)Math.Log10(remainder) + 1 == 2)
            //        {
            //            remainder = remainder % 10;
            //            result.Add(remainder);

            //        }

            //    }
            //    result.Add(remainder);
            //    k = k / 10;
            //    carry = 0;
            //}
            if (carry == 1) result.Add(carry);
            result.Reverse();
            return result;

        }

        /*
         * 
         * Example: `num` = [2,1,5], `k` = 806
At index 2 num = [2, 1, 811] 
So, `k` = 81 and `num` = [2, 1, 1]

At index 1 num = [2, 82, 1]
So, `k` = 8 and `num` = [2, 2, 1]

At index 0 num = [10, 2, 1]
So, `k` = 1 and `num` = [0, 2, 1]

Now `k` > 0
So, we add at the beginning of num
`num` = [1, 0, 2, 1]
         * */
        // Better approach
        public IList<int> AddToArrayForm2(int[] num, int k)
        {
            List<int> res = new List<int>();
            for (int i = num.Length - 1; i >= 0; --i)
            {
                res.Add((num[i] + k) % 10);
                k = (num[i] + k) / 10;
            }
            while (k > 0)
            {
                res.Add(k % 10);
                k /= 10;
            }
            res.Reverse();
            return res;
        }


        // this is also easy and I like it more. Add num[i] to K and insert k%10. After adding remainder, find it quotient. run until you check that K >0
        public IList<int> AddToArrayForm3(int[] num, int k)
        {
            LinkedList<int> result = new LinkedList<int>();
            int len = num.Length - 1;
         
            while (len >= 0 || k != 0)
            {

                if (len >= 0)
                {
                    k += num[len--];
                }

                result.AddFirst(k % 10);
                k /= 10;
            }

            return result.ToArray();
        }
    }
}
