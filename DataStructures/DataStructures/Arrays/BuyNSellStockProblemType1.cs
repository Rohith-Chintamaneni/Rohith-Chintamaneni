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
            // first you want to find the minimum price at which you want to buy a stock. After finding out the minimum price, you need to calculate the max profit
            if (prices == null || prices.Length == 0)
                return 0;

            int maxprofit = 0;
            int minpriceofstock = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (minpriceofstock >
                    prices[i]) // you need to check that if MInPriceStock is less but you write the other way.
                {
                    minpriceofstock = prices[i];
                }
                else
                {
                    maxprofit = Math.Max(maxprofit, prices[i] - minpriceofstock);
                }
            }


            return maxprofit;

        }
        //if (prices == null || prices.Length == 0)
        //    return 0;
        //int max = prices[prices.Length - 1], maxProfit = 0;
        //for (int i = prices.Length - 1; i >= 0; --i)
        //{
        //    maxProfit = Math.Max(maxProfit, max - prices[i]);
        //    max = Math.Max(max, prices[i]);
        //}
        //return maxProfit;


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




        //prices = [7,1,5,3,6,4]

        //public int MaxProfitWith2PointerLeftandRight(int[] prices)
        //{
        //    int maxprofit = 0, profit = 0;
        //    int left=0;
        //    int right = prices.Length-1;

        //    while (left < right)
        //    {
               
               
        //        if (prices[left] > prices[right])
        //        {
        //            left++;
        //        }
        //        else if(prices[left] < prices[right])
        //        {
        //            profit = prices[right] - prices[left];
        //            maxprofit = Math.Max(maxprofit, profit);
        //            left++;
                   
        //            // right--;
        //        }
        //        else
        //        {
        //            right--;
        //        }
               
        //    }

        //    return maxprofit;
        //}
    }
}