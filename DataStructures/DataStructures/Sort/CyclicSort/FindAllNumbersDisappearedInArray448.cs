using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Sort.CyclicSort
{
    class FindAllNumbersDisappearedInArray448
    {
        public List<int> FindDisappearedNumbers(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] == i + 1 || nums[i] == nums[nums[i] - 1])
                {
                    i++;
                    continue;
                }
                int tmp = nums[i];
                nums[i] = nums[nums[i] - 1];
                nums[tmp - 1] = tmp;

            }
            List<int> result = new List<int>();
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                    result.Add(j + 1);
            }
            return result;
        }
 


    public List<int> FindDisappearedNumbers2(int[] nums)
    {
    int i = 0;

    int n = nums.Length;
        while(i<n)
    {
        /*
            [2, 2, 3, 4, 5] 
            for this example when i = 0, does 2 present at nums[2 - 1] index, if not then perform the swap operation, if yes simply increment i
        */
        if (nums[i] != nums[nums[i] - 1])
        {
            swap(nums, i, nums[i] - 1);
        }
        else
        {
            i++;
        }

    }

    List<int> ans = new List<int>();
        for (i = 0; i<nums.Length; i++)
    {
        if (i != nums[i] - 1)
        {
            ans.Add(i + 1);
        }
        }
    
    return ans;
}
    public void swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
        // CYclic Sort
        public IList<int> FindDisappearedNumbers3(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                int corrected = nums[i] - 1;
                if (nums[i] != nums[corrected])
                {
                    Swap(nums, i, corrected);
                }
                else i++;
            }
            var list = new List<int>();
            for (int m = 0; m < nums.Length; m++)
            {
                if (m != nums[m] - 1) list.Add(m + 1);
            }

            return list;
        }

        public void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

    }  
}
