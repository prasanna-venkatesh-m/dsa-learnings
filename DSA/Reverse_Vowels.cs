using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Reverse_Vowels
    {
        public string ReverseVowels(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int start = 0;
            int end = sb.Length - 1;
            while(start < end)
            {
                if (isVowel(sb[start]) && isVowel(sb[end]))
                {
                    char temp = sb[start];
                    sb[start++] = sb[end];
                    sb[end--] = temp;
                }
                else if(isVowel(sb[start]) && !isVowel(sb[end]))
                {
                    end--;
                }
                else if(!isVowel(sb[start]) && isVowel(sb[end]))
                {
                    start++;
                }
                else
                {
                    start++;
                    end--;
                }
            }
            return sb.ToString();
        }

        public bool isVowel(char c)
        {
            if(Char.ToLowerInvariant(c)=='a' || Char.ToLowerInvariant(c)=='e' || Char.ToLowerInvariant(c)=='i' || Char.ToLowerInvariant(c) == 'o' || Char.ToLowerInvariant(c)=='u')
            {
                return true;
            }
            return false;
        }
    }
}
