using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Range_Sum_Query
    {
        private int[] nums;
        public Range_Sum_Query(int[] nums)
        {
            this.nums = nums;
            int sum = 0;
            for(int i=0; i < nums.Length; i++)
            {
                sum += nums[i];
                this.nums[i] = sum;
            }
        }

        public int SumRange(int left, int right)
        {
            int sum = 0;
            for(int i = left; i<=right; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
