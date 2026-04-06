using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Monotonic_Array
    {
        public bool IsMonotonic(int[] nums)
        {
            if (nums.Length < 2) return true;
            bool isIncreasing = nums[0] < nums[1];
            int lastNum = nums[1];
            for(int i=2; i<nums.Length; i++)
            {
                if(isIncreasing && !(lastNum <= nums[i]))
                {
                    return false;
                }
                if (!isIncreasing && !(lastNum >= nums[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
