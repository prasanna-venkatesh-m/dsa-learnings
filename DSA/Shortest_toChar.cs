using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Shortest_toChar
    {
        public int[] ShortestToChar(string s, char c)
        {
            int[] res = new int[s.Length];
            int i = 0;
            int left = -s.Length;
            int right = findRight(i, c, s);
            while(i < s.Length)
            {
                int shortest = Math.Min((i - (left)), (right - i));
                res[i] = shortest;
                i++;
                if (shortest == 0)
                {
                    left = right;
                    right = findRight(i, c, s);
                }
            }
            return res;
        }

        public int findRight(int startIndex, char findC, string s)
        {
            for(int i=startIndex; i<s.Length; i++)
            {
                if (s[i] == findC) return i;
            }
            return int.MaxValue;
        }
    }
}
