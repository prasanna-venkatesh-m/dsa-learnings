using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Shortest_toChar
    {
        public int[] ShortestToChar(string s, char c)
        {
            int[] left = new int[s.Length];
            int[] right = new int[s.Length];
            int[] res = new int[s.Length];
            int leftMax = -10001;
            int rightMax = 200001;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == c) leftMax = i;
                left[i] = i- leftMax;
            }
            for (int i = s.Length-1; i >=0; i--)
            {
                if (s[i] == c) rightMax = i;
                right[i] = rightMax - i;
            }
            for (int i = 0; i < s.Length; i++)
            {
                res[i] = Math.Min(left[i], right[i]);
            }
            return res;
        }
    }
}
