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
            int max = 0;
            int maxIndex = -1;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] >= max)
                {
                    max = prices[i];
                    maxIndex = i;
                }
            }
            int small = max;
            for(int i = 0; i< maxIndex; i++)
            {
                small = prices[i] <= small ? prices[i] : small;
            }
            return max - small;
        }
    }
}
