using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Sort_EvenOdd
    {
        public int[] SortEvenOdd(int[] nums)
        {
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();

            for(int i=0;i< nums.Length; i++)
            {
                if (i % 2 == 0) evens.Add(nums[i]);
                else odds.Add(nums[i]);
            }

            odds = odds.OrderByDescending(x=>x).ToList();
            evens = evens.OrderBy(x => x).ToList();

            int k = 0;

            foreach(int val in evens)
            {
                if (k < nums.Length)
                {
                    nums[k] = val;
                    k += 2;
                }
            }

            int j = 1;

            foreach (int val in odds)
            {
                if (j < nums.Length)
                {
                    nums[j] = val;
                    j += 2;
                }
            }
            return nums;
        }
    }
}
