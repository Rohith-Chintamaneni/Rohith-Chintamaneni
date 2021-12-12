using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort
{
    class MajorityElement
    {
        //Boyers Moore alogirthm
        public int MajorityElementProblem(int[] num)
        {
            int majorelement = num[0], count = 1;
            for (int i = 1; i < num.Length; i++)
            {
                if (count == 0)
                {
                    majorelement = num[i];
                    count++;

                }
                else if (num[i] == majorelement)
                {
                    count++;
                }
                else
                {
                    count--;
                }
                
            }

            return majorelement;
        }
    }
}
