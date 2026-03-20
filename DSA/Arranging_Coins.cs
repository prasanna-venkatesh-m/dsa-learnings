using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Arranging_Coins
    {
        public int ArrangeCoins(int n)
        {
            if (n <= 0) return 0;
            int count = 0;
            int sum = 1;
            int i = 2;
            while (sum <= n)
            {
                sum = sum + i++;
                count++;
            }
            return count;
        }
    }
}
