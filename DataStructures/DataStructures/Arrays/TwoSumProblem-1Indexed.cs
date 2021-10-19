using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataStructures.Arrays
{
    public class TwoSumProblemIndexed
    {
        public int[] TwoSumNSquare(int[] nums, int target)
        {
            var firstvalue = 0;
            var secondvalue = 0;
            int index1 = 0, index2 = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    firstvalue = nums[i];
                    secondvalue = nums[j];
                    if (firstvalue + secondvalue == target)
                    {
                        index1 = i;
                        index2 = j;
                        goto LoopEnd;
                    }
                }


            }

            LoopEnd:
            return new int[2] { index1, index2 };
        }

        public int[] TwoSumN(int[] nums, int target)
        {
            var numdictionary = new Dictionary<int, int>();
            int runningnumber = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (numdictionary.ContainsKey(target - nums[i]))
                {
                    return new int[2] { numdictionary[target - nums[i]], runningnumber };
                }

                numdictionary[nums[i]] = runningnumber;
                runningnumber++;
            }

            return new int[2];
        }


        public int[] TwoSumN2pointer(int[] nums, int target)
        {
            int[] result = new int[2];
            int i = 0, n = nums.Length-1;
            while (i<n)
            {
                if (nums[i] + nums[n] > target) n--;

                if (nums[i] + nums[n] < target) i++;

                if (nums[i] + nums[n] == target)
                {
                    result[0] = ++i;
                    result[1] = ++n;
                }
            }


            return result;
        }
    }


   

    //var existingVals = new Dictionary<int, int>();

        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (existingVals.ContainsKey(target - nums[i]))
        //        return new int[] { i, existingVals[target - nums[i]] };

        //    existingVals.TryAdd(nums[i], i);
        //}
        //return new int[] { };




        //if (nums == null || nums.Length < 2)
        //    return new int[2];

        //Dictionary<int, int> dic = new Dictionary<int, int>();

        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (dic.ContainsKey(target - nums[i]) && true && true)
        //        return new int[] { i, dic[target - nums[i]] };
        //    else if (!dic.ContainsKey(nums[i]))
        //        dic.Add(nums[i], i);
        //}

        //return new int[2];

    }


