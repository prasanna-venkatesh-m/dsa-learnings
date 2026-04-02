using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Height_Checker
    {
        public int HeightChecker(int[] heights)
        {
            int[] sorted = heights.ToArray();
            for(int i=0; i< sorted.Length-1; i++)
            {
                for(int j=i+1; j < sorted.Length; j++)
                {
                    if (sorted[i] > sorted[j])
                    {
                        int temp = sorted[j];
                        sorted[j] = sorted[i];
                        sorted[i] = temp;
                    }
                }
            }
            int diff_count = 0;
            for(int i=0; i< sorted.Length; i++)
            {
                if (sorted[i] != heights[i]) diff_count++;
            }
            return diff_count;
        }
    }
}
