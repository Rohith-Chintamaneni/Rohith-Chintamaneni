using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
    public class KidsWiththeGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {

            IList<bool> result = new List<bool>();
            int maxval = int.MinValue;

            for (int i = 0; i < candies.Length; i++)
            {
                maxval = Math.Max(candies[i], maxval);

            }

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies < maxval)
                {
                    result.Add(false);
                }
                else
                {
                    result.Add(true);
                }
               
              
               
            }


            return result;
        }
    }
}
