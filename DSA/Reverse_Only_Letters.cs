using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Reverse_Only_Letters
    {
        public string ReverseOnlyLetters(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int start = 0;
            int end = sb.Length - 1;

            while(start < end)
            {
                if (!isAlphabet(sb[start]))
                {
                    start++;
                }
                else if (!isAlphabet(sb[end]))
                {
                    end--;
                }
                else
                {
                    char temp = sb[start];
                    sb[start++] = sb[end];
                    sb[end--] = temp;
                }
            }

            return sb.ToString();
        }

        public bool isAlphabet(char c)
        {
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) return true;
            return false;
        }
    }
}
