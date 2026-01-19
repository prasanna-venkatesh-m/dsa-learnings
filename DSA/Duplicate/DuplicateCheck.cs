using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA.Duplicate
{
    public class DuplicateCheck
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums==null || nums.Length < 2) return false;

            HashSet<int> table = new HashSet<int>(nums.Length);
            foreach(int i in nums)
            {
                if (!table.Add(i))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
