using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.PrefixSum
{
    public class SubarraySumEqualsK
    {
        // THis problem can't be solved using sliding window becuase at the end the sliding window is use to calculate subarray or subsequence. In this question we dont want subarray.
        // prefix sum with Dictionary. WHy and this problem is not able to be processed by sliding window
        /*
         * Use the prefix sum technique when:

        You need to perform range queries on an array, such as finding the sum of elements between two indices.
        The problem involves multiple queries on different subranges.
        The problem can be solved in constant time complexity (O(1)) for each query after the initial precomputation.
        The extra space required for storing the prefix sum array is acceptable.
        Certainly! Let's discuss why the prefix sum technique is more suitable for solving the original problem of counting subarrays with a sum equal to `k`, as opposed to the sliding window technique.

        **Original Problem:**
        Given an array `nums` and an integer `k`, you want to find the total number of subarrays whose sum equals `k`.

        **Why Prefix Sum:**

        1. **Variable Subarray Length:** In the problem, the subarrays can have varying lengths. This makes it challenging to apply the sliding window technique, which is typically used for fixed-size subarrays.

        2. **Counting Occurrences:** The goal is to count the number of subarrays that satisfy the condition. Prefix sum provides a way to efficiently check for specific sum values between different indices without having to maintain and adjust a sliding window.

        3. **Non-Contiguous Subarrays:** The sliding window technique is designed for contiguous subarrays. The problem here allows for non-contiguous subarrays, which further makes the sliding window approach less applicable.

        4. **Efficient Range Queries:** The prefix sum technique optimizes problems involving range queries. In this problem, you're interested in finding subarrays with a specific sum (`k`), which can be thought of as a range query.

        5. **Time Complexity:** The prefix sum technique provides a solution with linear time complexity (`O(n)`) where `n` is the length of the array. The sliding window technique in this case would likely involve nested loops, which would lead to a higher time complexity.

        In contrast, the sliding window technique is better suited for problems where you need to find subarrays of a fixed size that meet certain criteria, such as maximum/minimum sum subarray or longest substring with distinct characters. It's useful when you need to maintain a window over a sequence and update it as you iterate through the data.

        For the original problem, the prefix sum technique's ability to efficiently track cumulative sums and their frequencies aligns well with the problem's requirements, making it a more suitable choice compared to the sliding window technique.

        */

        public int SubarraySum(int[] nums, int k)
{
    Dictionary<int, int> map = new Dictionary<int, int>();
    int n = nums.Length;
    int sum = 0;
    int count = 0;

    for (int i = 0; i < n; i++)
    {
        sum += nums[i];
        if (sum == k)
            count++;
        if (map.ContainsKey(sum - k))  // k = prefixsum[j] - prefixsum[i-1]  as per range sum queries. this is translated to prefixsum[i-1] = prefixsum[j]-k. Here prefixsum[j] means sum. Since you are calculating prefix sum upto that point using sum variable.Hence all these values are placed in a Dicitionary and we set the frequencies of those.
        {
            count += map[(sum - k)];
        }
        if (map.ContainsKey(sum))
        {
            map[sum]=  map[sum] + 1;
        }
        else
            map[sum] =  1;
    }
    return count;
}

        // the problem can be solved by array but you will have hard time since you can keep the count. Hence dicitionary is better.
        public int SubarraySum2(int[] nums, int k)
        {
            int count = 0;
            int sum = 0;

            // Create a prefix sum dictionary
            Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();
            prefixSumCount.Add(0, 1); // Initialize with sum 0 count 1

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                // Check if prefix sum of (sum - k) exists in the dictionary
                if (prefixSumCount.ContainsKey(sum - k))
                {
                    count += prefixSumCount[sum - k];
                }

                // Add the current prefix sum to the dictionary
                if (!prefixSumCount.ContainsKey(sum))
                {
                    prefixSumCount.Add(sum, 0);
                }
                prefixSumCount[sum]++;
            }

            return count;
        }

        // here still all subarrays are calculated using 2 loops.
        public int SubarrySum3(int[] nums, int k)
        {
            int count = 0;
            int[] prefixSum = new int[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                prefixSum[i + 1] = prefixSum[i] + nums[i];
            }

            for (int start = 0; start < nums.Length; start++)
            {
                for (int end = start; end < nums.Length; end++)
                {
                    int sum = prefixSum[end + 1] - prefixSum[start];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }

            return count;

        }

        /* very important Please understand
         * 
         * In the context of the "Subarray Sum Equals K" problem, the dictionary is used to store information about the cumulative prefix sums encountered during the traversal of the input array. Specifically, the dictionary stores the following key-value pairs:

Key: The cumulative prefix sum up to the current index.
Value: The count of how many times that cumulative prefix sum has been encountered so far.
Here's how the dictionary is utilized in the problem:

Initialization: The dictionary is initially populated with a single entry: {0, 1}. This entry represents the situation where the cumulative sum up to that point is 0 (i.e., no elements have been considered yet). The count is initialized to 1.

Traversal: As we iterate through the array, we calculate the cumulative sum at each index. Let's call this sum currentSum. We check if the dictionary already contains an entry with the key currentSum - k. If such an entry exists, it means there are subarrays in the previous portion of the array that sum up to k. We add the count associated with this entry to the final result.

Updating the Dictionary: After checking for the previous prefix sum, we update the dictionary with the current currentSum. If the key is not present in the dictionary, we add it and initialize its count to 1. If the key already exists, we increment its count.

By storing the cumulative prefix sums in the dictionary and their corresponding counts, we can efficiently determine the number of subarrays with a sum of k. This approach is based on the principle that the difference between two cumulative prefix sums gives us the sum of elements between the corresponding indices, which is the core concept behind solving this problem using the prefix sum technique.





Regenerate
*/
    }
}
