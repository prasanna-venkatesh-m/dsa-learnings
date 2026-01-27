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
            Sort(nums1, 0, nums1.Length);
            foreach(int i in nums1)
            {
                Console.WriteLine(i);
            }
        }

        public void Sort(int[] nums, int start, int end)
        {
            if (end-start == 1)
            {
                return;
            }

            int mid = (start + end) / 2;

            Sort(nums, start, mid);
            Sort(nums, mid, end);
            Merge(nums, start, mid, end);
        }

        public void Merge(int[] nums, int start, int mid, int end)
        {
            int[] joined = new int[end - start];

            int i = start;
            int j = mid;
            int k = 0;

            while(i < mid && j < end)
            {
                if (nums[i] <= nums[j])
                    joined[k++] = nums[i++];
                else
                    joined[k++] = nums[j++];
            }

            while (i < mid)
            {
                joined[k++] = nums[i++];
            }
            while (j < end)
            {
                joined[k++] = nums[j++];
            }

            for(int z=0; z < joined.Length; z++)
            {
                nums[start + z] = joined[z];
            }
        }
    }
}
