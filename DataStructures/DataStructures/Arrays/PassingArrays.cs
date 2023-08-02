using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class PassingArrays
    {
      
        // it a copy of reference variable is made but not the actual value is copied. Hence a change is reflected
        public void PassByValue(int[] nums)
        {
            nums[0] = 99; 
            nums = new int[] { 10, 11, 12 }; // now nums is pointing to a new location. Remeber this is another copy of reference variable. Change made here does not impact the original variable
        }

        public void PassByReference(ref int[] nums)
        {
            nums[0] = 0; // will still change to 99 and then the whole varibale is now pointing to new location and that will be used
            nums = new int[] { 14, 15, 16 };
        }

      
    }
}
