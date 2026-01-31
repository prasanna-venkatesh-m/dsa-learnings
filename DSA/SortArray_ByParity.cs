using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class SortArray_ByParity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int i = 0;
            int j = 1;
            while(i < nums.Length && j < nums.Length)
            {
                if (nums[i]%2 == 1 && nums[j]%2 == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                    j++;
                }
                else if (nums[i] % 2 == 0 && nums[j] % 2 == 1)
                {
                    i=j;
                    j++;
                }
                else if (nums[i] % 2 == 1 && nums[j] % 2 == 1)
                {
                    j++;
                }
                else if (nums[i] % 2 == 0 && nums[j] % 2 == 0)
                {
                    i += 2;
                    j += 2;
                }
            }
            return nums;
        }
    }
}
