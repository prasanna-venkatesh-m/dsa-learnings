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
            return nums.GroupBy(x => x).Select(x => new
            {
                val = x.Key,
                counts = x.Count()
            }).Where(x => x.counts == 1).Select(x => x.val).FirstOrDefault();
        }
    }
}
