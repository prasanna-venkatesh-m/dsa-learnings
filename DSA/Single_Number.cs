using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Single_Number
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num; // XOR accumulates
            }
            return result;

            //Solution 2
            //HashSet<int> result = new HashSet<int>();
            //foreach(int i in nums)
            //{
            //    if (result.Contains(i))
            //    {
            //        result.Remove(i);
            //    }
            //    else
            //    {
            //        result.Add(i);
            //    }
            //}
            //return result.FirstOrDefault();

            //Solution 1
            //return nums.GroupBy(x => x).Select(x => new
            //{
            //    val = x.Key,
            //    counts = x.Count()
            //}).Where(x => x.counts == 1).Select(x => x.val).FirstOrDefault();
        }
    }
}
