using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Power_of_four
    {
        public bool IsPowerOfFour(int n)
        {
            if (n == 0) return false;
            double power = Math.Round(Math.Log(n) / Math.Log(4));
            double res = Math.Pow(4, power);
            return res == n;
        }
    }
}
