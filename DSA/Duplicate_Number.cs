using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Duplicate_Number
    {
        public int FindDuplicate(int[] nums)
        {
            int[] res = new int[nums.Length+1];
            foreach(int i in nums)
            {
                if (res[i] == 0)
                {
                    res[i] = 1;
                }
                else
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
