using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Contains_Duplicate_II
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Hashtable ht = new Hashtable();
            for(int i=0; i < nums.Length; i++)
            {
                if (ht.ContainsKey(nums[i]))
                {
                    if(Math.Abs(((int)ht[nums[i]] - i)) <= k)
                    {
                        return true;
                    }
                    else
                    {
                        ht[nums[i]] = i;
                    }
                }
                else
                {
                    ht.Add(nums[i], i);
                }
            }
            return false;
        }
    }
}
