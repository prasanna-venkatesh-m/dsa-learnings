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
            int address1 = 0;
            int address2 = 1;
            while (nums[address1] == nums[address2] && address2 < nums.Length)
            {
                address1++;
                address2++;
                if (address2 >= nums.Length)
                {
                    return true;
                }
            }
            bool isIncreasing = nums[address1] < nums[address2];
            int lastNum = nums[address2];
            for(int i=address2+1; i<nums.Length; i++)
            {
                if(isIncreasing && !(lastNum <= nums[i]))
                {
                    return false;
                }
                if (!isIncreasing && !(lastNum >= nums[i]))
                {
                    return false;
                }
                lastNum = nums[i];
            }
            return true;
        }
    }
}
