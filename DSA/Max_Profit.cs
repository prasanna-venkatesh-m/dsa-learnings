using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA
{
    public class Max_Profit
    {
        public int MaxProfit(int[] prices)
        {
            int minimumValue = prices[0];
            int maxProfit = 0;
            for(int i =1; i< prices.Length; i++)
            {
                if (prices[i] < minimumValue)
                {
                    minimumValue = prices[i];
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, (prices[i] - minimumValue));
                }
            }
            return maxProfit;
        }
    }
}
