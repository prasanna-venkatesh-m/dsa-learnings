using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach(int i in nums)
            {
                if (counts.ContainsKey(i))
                {
                    counts[i]++;
                }
                else
                {
                    counts.Add(i, 1);
                }
            }
            int max_count = 0;
            int key = 0;
            foreach (var item in counts)
            {
                if(item.Value > max_count)
                {
                    max_count = item.Value;
                    key = item.Key;
                }
            }
            return key;
        }
    }
}
