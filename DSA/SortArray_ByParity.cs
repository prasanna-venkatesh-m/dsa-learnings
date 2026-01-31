using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class SortArray_ByParity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int evenIndex = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[evenIndex];
                    nums[evenIndex] = temp;
                    evenIndex++;
                }
            }
            return nums;
        }
    }
}
