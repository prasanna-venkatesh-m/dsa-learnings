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
            List<int> res = new List<int>();
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    res.Add(prices[j] - prices[i]);
                }
            }
            return res.Count() > 0 ? (res.Max() > 0 ? res.Max() : 0)  : 0;
        }
    }
}
