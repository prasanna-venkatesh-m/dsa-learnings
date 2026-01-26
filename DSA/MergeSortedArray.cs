using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for(int i=0; i< n; i++)
            {
                nums1[m+ i] = nums2[i];
            }
            Array.Copy(Sort(nums1), nums1, nums1.Length);
        }

        public int[] Sort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }

            int mid = nums.Length / 2;

            int[] left = nums.Skip(0).Take(mid).ToArray();
            int[] right = nums.Skip(mid).Take(nums.Length - mid).ToArray();

            left = Sort(left);
            right = Sort(right);
            int[] joinedArray = Merge(left, right);

            return joinedArray;
        }

        public int[] Merge(int[] first, int[] second)
        {
            int[] joined = new int[first.Length + second.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while(i<first.Length && j < second.Length)
            {
                if (first[i] <= second[j])
                    joined[k++] = first[i++];
                else
                    joined[k++] = second[j++];
            }

            while (i < first.Length)
            {
                joined[k++] = first[i++];
            }
            while(j < second.Length)
            {
                joined[k++] = second[j++];
            }

            return joined;
        }
    }
}
