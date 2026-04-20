using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Shortest_toChar
    {
        public int[] ShortestToChar(string s, char c)
        {
            List<int> indexList = new List<int>(s.Length);
            int[] res = new int[s.Length];
            for(int i=0; i< s.Length; i++)
            {
                if (s[i]==c)
                {
                    indexList.Add(i);
                }
            }
            for(int i=0; i< s.Length; i++)
            {
                res[i] = indexList.Select(x=> Math.Abs((x - i))).OrderBy(x=>x).FirstOrDefault();
            }
            return res;
        }
    }
}
