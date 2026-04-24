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
            Hashtable ht = new Hashtable();
            for(int i=0; i<nums.Length; i++)
            {
                if (ht.ContainsKey(nums[i]))
                {
                    ht[nums[i]] = 1 + (int)ht[nums[i]];
                }
                else
                {
                    ht.Add(nums[i], 1);
                }
            }
            
            int res = 0;
            foreach (DictionaryEntry entry in ht)
            {
                if ((int)entry.Value == 1)
                {
                    res += (int)entry.Key;
                }
            }
            return res;
        }
    }
}
