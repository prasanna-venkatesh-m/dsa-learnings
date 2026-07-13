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
            for (int i = prices.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    max = (prices[i] - prices[j]) > max ? prices[i] - prices[j] : max;
                }
            }
            return max;
        }
    }
}
