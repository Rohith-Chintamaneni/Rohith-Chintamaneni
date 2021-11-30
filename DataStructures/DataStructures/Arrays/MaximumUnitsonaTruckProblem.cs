using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    class MaximumUnitsonaTruckProblem
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {

            Array.Sort(boxTypes, (a, b) => b[1] - a[1]);
            int finalcount = 0;
            for (int i = 0; i < boxTypes.Length; i++)
            {
                var boxcountleft = Math.Min(truckSize, boxTypes[i][0]);
                truckSize -= boxcountleft;
                finalcount += boxcountleft * boxTypes[i][1];
                if (truckSize == 0) return finalcount;
            }
           return finalcount;
        }

    }
}
