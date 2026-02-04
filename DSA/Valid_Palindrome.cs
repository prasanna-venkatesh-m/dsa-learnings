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
            string filteredText = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
            char[] chars = filteredText.ToLower().ToCharArray();

            int start = 0;
            int end = chars.Length - 1;

            while( start != end && start <= end)
            {
                if (chars[start] == chars[end])
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
