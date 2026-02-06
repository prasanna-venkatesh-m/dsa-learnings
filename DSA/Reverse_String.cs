using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Reverse_String
    {
        public void ReverseString(char[] s)
        {
            int start = 0;
            int end = s.Length - 1;

            while(start < end)
            {
                char temp = s[start];
                s[start++] = s[end];
                s[end--] = temp;
            }
        }
    }
}
