using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Arranging_Coins
    {
        public int ArrangeCoins(int n)
        {
            return (int)((Math.Sqrt(1 + 8L * n) - 1) / 2);
        }
    }
}
