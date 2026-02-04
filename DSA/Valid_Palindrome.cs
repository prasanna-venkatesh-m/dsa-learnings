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
            string filteredText = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            int start = 0;
            int end = filteredText.Length - 1;

            while( start != end && start <= end)
            {
                if (filteredText[start] == filteredText[end])
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
