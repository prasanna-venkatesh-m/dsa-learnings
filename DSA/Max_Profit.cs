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
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    max = (prices[j] - prices[i]) > max ? prices[j] - prices[i] : max;
                }
            }
            return max;
        }
    }
}
