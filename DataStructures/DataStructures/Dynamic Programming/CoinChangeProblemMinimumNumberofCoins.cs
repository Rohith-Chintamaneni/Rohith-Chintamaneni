using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace DataStructures.Dynamic_Programming
{
    class CoinChangeProblemMinimumNumberofCoins
    {
        private int?[,] t;
        public int CoinChangeUsingRecursion(int[] coins, int amount)
        {
            int result;
            result = CoinChange_Recursion(coins, amount, coins.Length);

            return result;
        }

        public int CoinChange_Recursion(int[] coins, int amount, int length)
        {
            if (amount == 0) return 1;

            if (length <= 0 || amount < 0) return 0;
            int count;
            if (coins[length - 1] <= amount)
            {
                count = 1+ Math.Min(CoinChange_Recursion(coins, amount - coins[length-1], length),
                    CoinChange_Recursion(coins, amount, length - 1));
            }
            else
            {
                count = CoinChange_Recursion(coins, amount, length - 1);
            }

            return count;
        }

        public int CoinChangeUsingRecursionWithMemoize(int[] coins, int amount)
        {
            // Minimum number of coins required to make amount 0 is 0
            if (amount == 0)
            {
                return 0;
            }
            t = new int?[coins.Length + 1,amount + 1];
            CoinChange_Memoize(coins, amount, coins.Length);
            return t[coins.Length,amount] == int.MaxValue - 1 ? -1 : t[coins.Length,amount].Value;
        }

        public int CoinChange_Memoize(int[] coins, int amount, int n)
        {
            // If we do not have any coins, we can not create any amount. So, infinity coins are required to create the required amount.
            if (n <= 0 && amount >= 0)
            {
                return int.MaxValue - 1;
            }

            // Minimum number of coins required to make amount 0 is 0.
            if (amount == 0)
            {
                return 0;
            }

            // If we have already solved the subproblem, return value.
            if (t[n,amount] != null)
            {
                return t[n,amount].Value;
            }

            // If coin value is greater than amount, then coin is useless and we will skip the coin.
            if (coins[n - 1] > amount)
            {
        
                t[n, amount] = CoinChange_Memoize(coins, amount, n - 1);
                return t[n, amount].Value;
            }

            // As we have unlimited supply of coins, we will keep using it towards the amount until the amount is smaller than the coin value.
            int includeCoin = CoinChange_Memoize(coins, amount - coins[n - 1], n);

            // We will skip the coin and give other coins chance.
            int excludeCoin = CoinChange_Memoize(coins, amount, n - 1);

            // Check the min for both posibilties and save the result of current subproblem.
            t[n,amount] = Math.Min(excludeCoin, includeCoin + 1);
            return t[n, amount].Value;
        }

        public int CoinChange_Memoize_Notworking(int[] coins, int amount, int length)
        {
            if (amount == 0) return 1;
            if (amount % coins[length - 1] != 0) return -1;

            if (length <= 0 || amount < 0) return 0;
            int count;

            if (t[length, amount] != null) return t[length, amount].Value;

            if (coins[length - 1] <= amount)
            {
                count = 1 + Math.Min(CoinChange_Memoize(coins, amount - coins[length - 1], length),
                    CoinChange_Memoize(coins, amount, length - 1));
                t[length, amount] = count;
                
            }
            else
            {
                count = CoinChange_Memoize(coins, amount, length - 1);
                t[length, amount] = count;
            }

            return count;
        }


        public int CoinChangeUsingDP(int[] coins, int amount)
        {
            int result;
            t = new int?[coins.Length + 1, amount + 1];
            for (int i = 0; i < coins.Length +1; i++)
            {
                for (int j = 0; j < amount+1; j++)
                {
                    if (i == 0) t[i, j] = int.MaxValue - 1;
                    if (j == 0) t[i, j] = 0;
                }
                
            }

            for (int j = 1; j < amount + 1; j++)
            {
                if (j % coins[0] == 0) t[1, j] = j / coins[0];
                else
                {
                    t[1, j] = int.MaxValue - 1;
                }
            }


            for (int i = 1; i < coins.Length + 1; i++)
            {
                for (int j = 1; j < amount+1; j++)
                {
                    if (coins[i-1] <= j)
                    {
                        t[i, j] = Math.Min(t[i, j - coins[i - 1]].Value +1 , t[i - 1, j].Value);
                    }
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
                
            }

            if (t[coins.Length,amount] < int.MaxValue - 1)
            {
                return t[coins.Length,amount].Value;
            }
            else
            {
                return -1;
            }
           
        }
    }
}
