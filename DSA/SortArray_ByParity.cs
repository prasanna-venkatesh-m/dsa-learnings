using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class SortArray_ByParity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            for(int i=0; i<nums.Length-1; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] % 2 == 0)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
            }
            return nums;
        }
    }
}
