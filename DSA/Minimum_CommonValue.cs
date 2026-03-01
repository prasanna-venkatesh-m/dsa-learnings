using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Minimum_Commonvalue
    {
        public int GetCommon(int[] nums1, int[] nums2)
        {
            int pointer1 = 0;
            int pointer2 = 0;
            while (pointer1 < nums1.Length && pointer2 < nums2.Length)
            {
                if (nums1[pointer1] == nums2[pointer2])
                {
                    return nums1[pointer1];
                }
                else if(nums1[pointer1] > nums2[pointer2])
                {
                    pointer2++;
                }
                else if(nums1[pointer1] < nums2[pointer2])
                {
                    pointer1++;
                }
            }
            return -1;
        }
    }
}
