using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class First_Matching_Index
    {
        public int FirstMatchingIndex(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            while(start <= end)
            {
                if (s[start] == s[end])
                {
                    return start;
                }
                start++;
                end--;
            }
            return -1;
        }
    }
}
