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
            char[] filteredText = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower().ToCharArray();
            char[] reversed = filteredText.Reverse().ToArray();
            return filteredText.SequenceEqual(reversed);
        }
    }
}
