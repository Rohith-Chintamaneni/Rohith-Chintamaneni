using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/minimum-cost-to-move-chips-to-the-same-position/submissions/
namespace DataStructures.Arrays
{
    public class MinimumCostTOMoveChips
    {
        // partially passed and again too complex. Had the idea of Odd and Even but I really went way complicated way
        public int MinCostToMoveChips2(int[] position)
        {
            int fcount = 0;
            int rcount = 0;
            int[] farray = new int[102];
            int[] rarray = new int[102];

            for (int i = 0; i < position.Length; i++)
            {
                var val = position[i];
                while (val > 100)
                {
                    val = val / 100;

                }
                farray[val] = farray[val] + 1;
                rarray[val] = rarray[val] + 1;
            }

            for(int i=1; i< farray.Length-2; i++)
            {
                farray[i + 2] = farray[i] + farray[i + 2];
                farray[i] = 0;
            }

            for (int i = 1; i < farray.Length - 1; i++)
            {
                farray[i + 1] = farray[i] + farray[i + 1];
                fcount = fcount + farray[i];
                farray[i] = 0;
            }

            for (int i = rarray.Length-1; i >=2 ; i--)
            {
                rarray[i - 2] = rarray[i] + rarray[i - 2];
                rarray[i] = 0;
            }

            for (int i = rarray.Length-1; i >= 1; i--)
            {
                rarray[i - 1] = rarray[i] + rarray[i - 1];
                rcount = rcount + rarray[i];
                rarray[i] = 0;
            }
            return Math.Min(fcount, rcount);

        }

        // count of evens
        // count of odds and finally to move even to odds it only 1 step, return the min of those
        public int MinCostToMoveChips(int[] position)
        {
            int odd = 0;
            int even = 0;

            for (int i = 0; i < position.Length; i++)
            {
                if (position[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }
           
            return Math.Min(even, odd);
        }
    }
}
