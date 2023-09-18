using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/fair-candy-swap/
namespace DataStructures.BinarySearchArrays
{
    public class FairCandySwap
    {
        // Brute Force
        public int[] FairCandySwap1(int[] aliceSizes, int[] bobSizes)
        {
            int alicesum = 0;
            for (int i = 0; i < aliceSizes.Length; i++)
            {
                alicesum += aliceSizes[i];
            }

            int bobsum = 0;
            for (int i = 0; i < bobSizes.Length; i++)
            {
                bobsum += bobSizes[i];
            }


            for (int i = 0; i < aliceSizes.Length; i++)
            {
                for (int j = 0; j < bobSizes.Length; j++)
                {
                    alicesum -= aliceSizes[i];
                    bobsum -= bobSizes[j];
                  var temp = aliceSizes[i];
                    aliceSizes[i] = bobSizes[j];
                    bobSizes[j] = temp;
                    alicesum += aliceSizes[i];
                    bobsum += bobSizes[j];
                    if (CheckSum(alicesum, bobsum))
                    {
                        temp = aliceSizes[i];
                        aliceSizes[i] = bobSizes[j];
                        bobSizes[j] = temp;
                        return new int[2] { aliceSizes[i], bobSizes[j] };
                    }
                    temp = aliceSizes[i];
                    aliceSizes[i] = bobSizes[j];
                    bobSizes[j] = temp;


                }
            }
            return new int[2];
        }
        public bool CheckSum(int alicesum, int bobsum)
        {
           

            if (alicesum == bobsum) return true;

            return false;
        }


        // Little improvement on checksum which made the solution accept.
        public int[] FairCandySwap2(int[] aliceSizes, int[] bobSizes)
        {


            int alicesum = 0;
            for (int i = 0; i < aliceSizes.Length; i++)
            {
                alicesum += aliceSizes[i];
            }

            int bobsum = 0;
            for (int i = 0; i < bobSizes.Length; i++)
            {
                bobsum += bobSizes[i];
            }


            for (int i = 0; i < aliceSizes.Length; i++)
            {
                for (int j = 0; j < bobSizes.Length; j++)
                {
                    alicesum -= aliceSizes[i];
                    bobsum -= bobSizes[j];
                    var temp = aliceSizes[i];
                    aliceSizes[i] = bobSizes[j];
                    bobSizes[j] = temp;
                    alicesum += aliceSizes[i];
                    bobsum += bobSizes[j];
                    if (CheckSum2(alicesum, bobsum))
                    {
                        temp = aliceSizes[i];
                        aliceSizes[i] = bobSizes[j];
                        bobSizes[j] = temp;
                        return new int[2] { aliceSizes[i], bobSizes[j] };
                    }
                    alicesum -= aliceSizes[i];
                    bobsum -= bobSizes[j];
                    temp = aliceSizes[i];
                    aliceSizes[i] = bobSizes[j];
                    bobSizes[j] = temp;
                    alicesum += aliceSizes[i];
                    bobsum += bobSizes[j];

                }
            }
            return new int[2];
        }
        public bool CheckSum2(int alicesum, int bobsum)
        {


            if (alicesum == bobsum) return true;

            return false;
        }

        // Intuition:  total(aliceCandies) - aliceCandies[i] + bobCandies[j] 
        //equals
        // total(bobCandies) - bobCandies[j] + aliceCandies[j]

/*public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) {

int aliceTotal = 0;
int bobTotal = 0;
aliceTotal = aliceSizes.Sum();
bobTotal = bobSizes.Sum();

int m = aliceSizes.Length, n = bobSizes.Length;
for (int i = 0; i < m; i++)
for (int j = 0; j < n; j++)
if ((aliceTotal - aliceSizes[i] + bobSizes[j]) == (bobTotal - bobSizes[j] + aliceSizes[i]))
  return new int[] { aliceSizes[i], bobSizes[j] };

return new int[0];
}
 * 
 * 
 * 
 * 
 */ 
}
}


/*
 * Binary Search Intuition + Approach
This builds off of previous solution by taking advantage of
the formula:

(aliceTotal - aliceSizes[i] + bobSizes[j]) == (bobTotal - bobSizes[j] + aliceSizes[i])
where
total(aliceCandies) = all candies initially owned by alice
total(bobCandies) = all candies initially owned by alice
aliceCandies[i] = chosen box of candies to trade FROM alice
bobCandies[i] = chosen box of candies to trade FROM bob

Because we know that what alice is trading is proportional to what bob is losing and bob's total, we arrive to the following formula to find bobSizes[j], which is what bob needs to trade to get an equivalent total from both sides:

A_total - A[i] + B[j] = B_total - B[j] + A[i]
B[j] + A_total - A[i] + B[j] = B_total + A[i]
2 * B[j] + A_total - A[i] = B_total + A[i]
2 * B[j] + A_total = B_total + A[i] + A[i]
2 * B[j] + A_total = B_total + 2 * A[i]
2 * B[j] = B_total - A_total + 2 * A[i]
B[j] = (B_total - A_total + 2 * A[i]) / 2
B[j] in this case is equivalent to target in the code that we are going to binary search every ith iteration, in bob's array.

However, first need to sort bob's array to be able to perform binary search.

Complexity
Time complexity:
O(nlogn + mlogn) - m is length of array from alice, and n is length of array from bob

Space complexity:
O(1) - no extra space is used

Code
  public int[] fairCandySwap(int[] aliceSizes, int[] bobSizes) {
    int aliceTotal = 0;
    int bobTotal = 0;
    for (int candies : aliceSizes)
      aliceTotal += candies;
    for (int candies : bobSizes)
      bobTotal += candies;
    
    Arrays.sort(bobSizes);
    
    int m = aliceSizes.length, n = bobSizes.length;
    for (int i = 0; i < m; i++) {      
      int target = (bobTotal + 2 * aliceSizes[i] - aliceTotal) / 2;
      if (binarySearch(bobSizes, target))
        return new int[] { aliceSizes[i], target };
    }

    return new int[0];
  }

  private boolean binarySearch(int[] arr, int target) {
    int l = 0, r = arr.length - 1;
    while (l <= r) {
      int m = l + (r - l) / 2;
      if (target < arr[m])
        r = m - 1;
      else if (target > arr[m])
        l = m + 1;
      else
        return true;
    }
    return false;
  }
HashMap Intuition + Approach
This again builds on previous intuition, where we can figure out hte corresponding pair that must be traded from bob. Store a hashmap of pairing between what alice trade (A[i]), and the calculation of what bob must trade.

Do a first pass on alice array to compute all keys (trades from bob that must satisfy the formula, given a trade from alice A[i])

Do another pass on bob's array, If the key existts in hashmap, then we found a pair, because this was precomputed in first pass.

Complexity
Time complexity:
O(m + n) - m is length of array from alice, and n is length of array from bob

Space complexity:
O(m) - For storing the target pairs from alice array, m is the length fo the array from alice

Code
class Solution {
  public int[] fairCandySwap(int[] aliceSizes, int[] bobSizes) {
    int aliceTotal = 0;
    int bobTotal = 0;
    for (int candies : aliceSizes) aliceTotal += candies;
    for (int candies : bobSizes) bobTotal += candies;
        
    Set<Integer> targets = new HashSet<>();
    for (int i = 0, m = aliceSizes.length; i < m; i++)
      targets.add((bobTotal - aliceTotal + 2 * aliceSizes[i]) / 2);

    for (int j = 0, n = bobSizes.length; j < n; j++)
      if (targets.contains(bobSizes[j]))
        return new int[] { (aliceTotal + 2 * bobSizes[j] - bobTotal) / 2, bobSizes[j] };

    return new int[0];
  }
}
*/