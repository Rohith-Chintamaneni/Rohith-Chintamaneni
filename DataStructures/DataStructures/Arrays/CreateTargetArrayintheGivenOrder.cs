using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class CreateTargetArrayintheGivenOrder
    {// Behind the scenes List is doing a lot. It is internall moving the elements
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> target = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                target.Insert(index[i], nums[i]);
            }
            return target.ToArray();
        }
        // Using Array.Copy Method
        public int[] CreateTargetArray1(int[] nums, int[] index)
        {
            int[] result = new int[index.Length];

            Array.Fill(result, -1);

            for (int i = 0; i < index.Length; i++)
            {

                int currentIndex = index[i];

                if (result[currentIndex] != -1)
                {
                    Array.Copy(result, currentIndex, result, currentIndex + 1, result.Length - currentIndex - 1);
                }

                result[currentIndex] = nums[i];
            }

            return result;

        }
    }
}
