using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Duplicate_Number
    {
        public int FindDuplicate(int[] nums)
        {
            //if (nums.Length < 3) return nums[0];

            //bool[] res = new bool[nums.Length + 1];
            //foreach (int i in nums)
            //{
            //    if (res[i] == false)
            //        res[i] = true;
            //    else
            //        return i;
            //}
            //return -1;

            if (nums.Length < 3) return nums[0];

            bool[] res = new bool[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                int j = nums[i];
                if (res[j]) return j;
                res[j] = true;
            }
            return -1;
        }
    }
}
