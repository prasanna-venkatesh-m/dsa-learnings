using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Power_of_three
    {
        public bool IsPowerOfThree(int n)
        {
            if (n == 0) return false;
            double power = Math.Round(Math.Log(n) / Math.Log(3));
            double res = Math.Pow(3, power);
            return res == n;
        }
    }
}
