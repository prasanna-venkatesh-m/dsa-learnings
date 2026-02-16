using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Find_Difference
    {
        public char FindTheDifference(string s, string t)
        {
            long s1 = 0;
            long s2 = 0;
            for(int i=0;i<s.Length; i++ )
            {
                s1 = s1 + s[i];
                s2 = s2 + t[i];
            }
            s2 = s2 + t[t.Length - 1];
            return Convert.ToChar(s2-s1);
        }
    }
}
