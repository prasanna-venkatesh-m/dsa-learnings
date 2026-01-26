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
            for(int i = 0; i < nums1.Length-1; i++)
            {
                for(int j = i + 1; j < nums1.Length; j++)
                {
                    if (nums1[i] > nums1[j])
                    {
                        int temp = nums1[i];
                        nums1[i] = nums1[j];
                        nums1[j] = temp;
                    }
                }
            }
            Console.WriteLine("Test");
        }
    }
}
