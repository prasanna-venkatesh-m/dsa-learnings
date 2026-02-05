using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DSA
{
    public class Valid_Palindrome
    {
        public bool IsPalindrome(string s)
        {
            int start = 0;
            int end = s.Length - 1;

            while( start != end)
            {
                if (!char.IsLetterOrDigit(s[start]))
                {
                    start++;
                }
                else if (!char.IsLetterOrDigit(s[end]))
                {
                    end--;
                }
                else if (char.ToLowerInvariant(s[start]) == char.ToLowerInvariant(s[end]))
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
