using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

// Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.

 

// Example 1:

// Input: nums = [3,2,1]
// Output: 1
// Explanation:
// The first distinct maximum is 3.
// The second distinct maximum is 2.
// The third distinct maximum is 1.
// Example 2:

// Input: nums = [1,2]
// Output: 2
// Explanation:
// The first distinct maximum is 2.
// The second distinct maximum is 1.
// The third distinct maximum does not exist, so the maximum (2) is returned instead.
// Example 3:

// Input: nums = [2,2,3,1]
// Output: 1
// Explanation:
// The first distinct maximum is 3.
// The second distinct maximum is 2 (both 2's are counted together since they have the same value).
// The third distinct maximum is 1.
 

// Constraints:

// 1 <= nums.length <= 104
// -231 <= nums[i] <= 231 - 1

namespace DSA
{
    public class Third_Maximum_Number
    {
        public int ThirdMax(int[] nums)
        {
            long max = long.MinValue;
            long second_max = long.MinValue;
            long third_max = long.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int numb = nums[i];
                if (numb >= max)
                {
                    if (max != numb)
                    {
                        third_max = second_max;
                        second_max = max;
                        max = numb;
                    }
                }
                else if (numb >= second_max)
                {
                    if (second_max != numb)
                    {
                        third_max = second_max;
                        second_max = numb;
                    }
                }
                else if (numb >= third_max)
                {
                    if (third_max != numb)
                    {
                        third_max = numb;
                    }
                }
            }
            return (nums.Length < 3 || third_max == long.MinValue) ? (int)max : (int)third_max;
        }
    }
}
