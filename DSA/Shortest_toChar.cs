using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Shortest_toChar
    {
        public int[] ShortestToChar(string s, char c)
        {
            int[] res = new int[s.Length];
            int prev = -10001;
            for (int i=0; i < s.Length; i++)
            {
                if (s[i] == c) prev = i;
                res[i] = i - prev;
            }
            prev = 10001;
            for (int i = s.Length-1; i >=0; i--) 
            {
                if (s[i] == c) prev = i;
                res[i] = Math.Min(res[i], prev - i); 
            }
            return res;
        }
    }
}
