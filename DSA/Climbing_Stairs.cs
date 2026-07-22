using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Climbing_Stairs
    {
        public int ClimbStairs(int n)
        {
            if (n < 4)
            {
                return n;
            }
            int start = 2;
            int current = 3;
            for (int i = 3; i < n; i++)
            {
                int temp = start;
                start = current;
                current = current + temp;
            }
            return current;
        }
    }
}
