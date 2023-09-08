using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/submissions/
namespace DataStructures.Arrays.PrefixSum
{
    public class MaximumPointsYouCanObtainfromCards
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            int[] prefix = new int[cardPoints.Length + 1];
            int[] suffix = new int[cardPoints.Length + 1];

            int sum = 0;
            int ans = 0;
            // prefix
            for (int i = 0; i < cardPoints.Length; i++)
            {
                prefix[i + 1] = prefix[i] + cardPoints[i];
            }
            // suffix
            for (int i = cardPoints.Length; i > 0; i--)
            {
                suffix[i - 1] = suffix[i] + cardPoints[i - 1];
            }
            int n = cardPoints.Length;

            for (int i = 0; i <= k; i++)
            {
                sum = prefix[i];
                ans = Math.Max(ans, sum + suffix[n - k + i]);

            }
            return ans;
        }
    }
}
