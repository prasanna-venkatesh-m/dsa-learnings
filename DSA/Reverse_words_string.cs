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
            for(int j=0;j<words.Length;j++)
            {
                for(int i = words[j].Length-1; i>=0; i--)
                {
                    sb.Append(words[j][i]);
                }
                if(j != words.Length - 1)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
    }
}
