using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length < 2) return;
            int i = 0;
            int j = 1;
            while(i < nums.Length-1 && j < nums.Length)
            {
                if (nums[i]==0 && nums[j] != 0)
                {
                    nums[i++] = nums[j];
                    nums[j++] = 0;
                }
                //else if (nums[j]==0 && nums[i] != 0)
                //{
                //    nums[j] = nums[i];
                //    nums[i] = 0;
                //    i++;
                //    j++;
                //}
                else
                {
                    j++;
                }
            }

            foreach(int k in nums)
            {
                Console.Write(k);
            }
        }
    }
}
