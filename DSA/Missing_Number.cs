using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Missing_Number
    {
        public int MissingNumber(int[] nums)
        {
            int sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }

            int actual = (nums.Length * (nums.Length + 1)) / 2;
            return actual - sum;
        }
    }
}
