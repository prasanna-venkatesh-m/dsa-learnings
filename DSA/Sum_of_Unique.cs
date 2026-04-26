using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Sum_of_Unique
    {
        public int SumOfUnique(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int i in nums) {
                if (counts.ContainsKey(i))
                {
                    counts[i]++;
                }
                else{
                    counts.Add(i, 1);
                }
            }
            int sum = 0;
            foreach (var pair in counts)
            {
                if (pair.Value == 1)
                {
                    sum += pair.Key;
                }
            }

            return sum;
        }
    }
}
