using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Reverse_words_string
    {
        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = s.Split(" ");
            int nospaces = words.Length - 1;
            foreach(string word in words)
            {
                sb.Append(reverse(word));
                if(nospaces > 0)
                {
                    sb.Append(" ");
                    nospaces--;
                }
            }
            return sb.ToString();
        }

        public StringBuilder reverse(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int start = 0;
            int end = sb.Length - 1;
            while (start < end)
            {
                char c = sb[start];
                sb[start++] = sb[end];
                sb[end--] = c;
            }
            return sb;
        }
    }
}
