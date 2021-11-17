using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Dynamic_Programming
{
    class CoinChangeWithMaximumWays
    {
        private int?[,] t;
       // private int[,] t;
        public int CoinChangeWithMaximumWaysRecursion(int[] coins, int sum)
        {

            int output = CoinChangeWithMaximumWaysusingRecursionMemoization(coins, sum, coins.Length);

            return output;
        }

        public int CoinChangeWithMaximumWaysusingRecursion(int[] coins, int sum, int length)
        {
            // base condition
            if (sum == 0) return 1;

            if (length <= 0 || sum < 0) return 0;
            int count;
            if (coins[length - 1] > sum)
            {
                count = CoinChangeWithMaximumWaysusingRecursion(coins, sum, length - 1);

            }
            else
            {
                count = CoinChangeWithMaximumWaysusingRecursion(coins, sum - coins[length - 1], length) +
                        CoinChangeWithMaximumWaysusingRecursion(coins, sum, length - 1);
            }

            return count;
        }

        public int CoinChangeWithMaximumWaysRecursion_Memoize(int[] coins, int sum)
        {
            t = new int?[coins.Length + 1, sum + 1];

            int output = CoinChangeWithMaximumWaysusingRecursionMemoization(coins, sum, coins.Length);

            return output;
        }

        public int CoinChangeWithMaximumWaysusingRecursionMemoization(int[] coins, int sum, int length)
        {
            int count;
            // base condition
            if (sum == 0) return 1;

            if (length <= 0 || sum < 0) return 0;

            if (t[length, sum] != null) return t[length, sum].Value;

            //if (coins[length - 1] > sum)
            //{
            //    count = CoinChangeWithMaximumWaysusingRecursionMemoization(coins, sum, length - 1);
            //    t[length, sum] = count;
            //}
            //else
            //{
            count = CoinChangeWithMaximumWaysusingRecursionMemoization(coins, sum - coins[length - 1], length) +
                    CoinChangeWithMaximumWaysusingRecursionMemoization(coins, sum, length - 1);
            t[length, sum] = count;
            // }

            return count;
        }


        public int CoinChangeWithMaximumWaysDP(int[] coins, int sum)
        {
            t = new int?[coins.Length + 1, sum + 1];
         
            for (int i = 0; i < coins.Length+1; i++)
            {
                for (int j = 0; j < sum+1; j++)
                {
                    if (i == 0) t[i, j] = 0;
                    if (j == 0) t[i, j] = 1;

                }
            }
            t[0, 0] = 1;

            int output = CoinChangeWithMaximumWaysusingDP(coins, sum, coins.Length);

            return output;
        }

        public int CoinChangeWithMaximumWaysusingDP(int[] coins, int sum, int length)
        {

            for (int i = 1; i < length+1; i++)
            {
                for (int j = 1; j < sum+1; j++)
                {
                    if (coins[i - 1] <= j)
                        t[i, j] = t[i, j - coins[i - 1]] + t[i - 1, j];
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
            }
    
            return t[length,sum].Value;
        }
    }
}
