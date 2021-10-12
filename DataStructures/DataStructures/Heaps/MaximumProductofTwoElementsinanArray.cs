using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Heaps
{
    public class MaximumProductofTwoElementsinanArray
    {
        public int MaxProduct(int[] nums)
        {
            int firstnumber = int.MinValue;
            int secondnumber = int.MinValue;

            foreach (var num in nums)
            {
                if (num > firstnumber)
                {
                    secondnumber = firstnumber;
                    firstnumber = num;
                }
                else if (num > secondnumber)
                    secondnumber = num;
            }
            return (firstnumber-1)*(secondnumber-1);
        }
    }
}
