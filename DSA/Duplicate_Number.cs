using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Duplicate_Number
    {
        public int FindDuplicate(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            foreach(int i in nums)
            {
                if (result.Contains(i))
                {
                    return i;
                }
                result.Add(i);
            }
            return -1;
        }
    }
}
