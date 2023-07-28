using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int rowlength = accounts.Length;
            int columnlength = accounts[0].Length;
            int sum = 0;
            int maxsum = Int32.MinValue;
            for (int i = 0; i < rowlength; i++)
            {
                for (int j = 0; j < columnlength; j++)
                {
                    sum += accounts[i][j];
                   // Console.WriteLine("[{0},{1}]={2}", i,j, accounts[i][j]);
                }

                maxsum = Math.Max(sum, maxsum);
                sum = 0;
            }

            return maxsum;
        }

        public int MaximumWealth1(int[][] accounts)
        {
            int rowlength = accounts.Length;
            int columnlength = accounts[0].Length;
           
            int maxsum = Int32.MinValue;
            for (int i = 0; i < rowlength; i++)
            {
                int sum = 0;
                for (int j = 0; j < columnlength; j++)
                {
                    sum += accounts[i][j];
                    // Console.WriteLine("[{0},{1}]={2}", i,j, accounts[i][j]);
                }

                maxsum = Math.Max(sum, maxsum);
              
            }

            return maxsum;
        }
    }
}
