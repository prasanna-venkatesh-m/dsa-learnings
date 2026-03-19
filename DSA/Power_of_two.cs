using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Power_of_two
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            double power = Math.Round(Math.Log(n) / Math.Log(2));
            double res = Math.Pow(2, power);
            return res == n;
        }
    }
}
