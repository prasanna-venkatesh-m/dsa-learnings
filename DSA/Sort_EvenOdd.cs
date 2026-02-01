using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Sort_EvenOdd
    {
        public int[] SortEvenOdd(int[] nums)
        {
            bool isOddArray = nums.Length % 2 == 0;
            int[] evens = new int[isOddArray ? (nums.Length / 2) : (nums.Length + 1) / 2];
            int[] odds = new int[nums.Length / 2];
            int eIndex = 0;
            int oIndex = 0;

            for(int i = 0; i< nums.Length; i++)
            {
                if (i % 2 == 0) evens[eIndex++] = nums[i];
                else odds[oIndex++] = nums[i];
            }

            evens = evens.OrderBy(x => x).ToArray();
            odds = odds.OrderByDescending(x => x).ToArray();

            int numsIndex = 0;
            for(int i=0;i<nums.Length/2; i++)
            {
                nums[numsIndex++] = evens[i];
                nums[numsIndex++] = odds[i];
            }
            if (!isOddArray) nums[numsIndex] = evens[evens.Length - 1];
            return nums;
        }
    }
}
