using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }

                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }
    }
}
