using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Arrays
{
    public class BuyNSellStockProblemType1
    {

        //prices = [7,1,5,3,6,4]
        public int MaxProfit(int[] prices)
        {

            if (prices == null || prices.Length == 0)
                return 0;
            int max = prices[prices.Length - 1], maxProfit = 0;
            for (int i = prices.Length - 1; i >= 0; --i)
            {
                maxProfit = Math.Max(maxProfit, max - prices[i]);
                max = Math.Max(max, prices[i]);
            }
            return maxProfit;


            //int minprice = int.MaxValue;
            //int maxprofit = 0;

            //for (int i = 0; i < prices.Length-1; i++)
            //{
            //    if (prices[i] < minprice)
            //    {
            //        minprice = prices[i];
            //    }
            //    else if (prices[i] - minprice > maxprofit)
            //    {
            //        maxprofit = prices[i] - minprice;
            //    }
            //}

            //return maxprofit;



            //var priceDictionary = new Dictionary<int, int>();
            //int j = 1;
            //int buyprice=0, salePrice = 0, diffamt = 0;
            //for (int i = 0; i < prices.Length-1; i++)
            //{
            //    if (prices[i] > prices[j])
            //    {
            //        buyprice = prices[j];
            //    }

              
            //}

            //return salePrice-buyprice;

            
        }
    }
}
