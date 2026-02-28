using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            int start = 0;
            int end = nums.Length - 1;
            int size = nums.Length;

            while(start <= end)
            {
                if (nums[end] == val)
                {
                    nums[end--] = '_';
                    size--;
                }
                else if (nums[start] == val)
                {
                    nums[start++] = nums[end];
                    nums[end--] = '_';
                    size--;
                }
                else
                {
                    start++;
                }
            }
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
            return size;
        }
    }
}
