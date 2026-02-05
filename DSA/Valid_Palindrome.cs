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
            s = s.ToLower();
            int start = 0;
            int end = s.Length - 1;

            while( start != end && start <= end)
            {
                if (checkIsSpecial(s[start]))
                {
                    start++;
                }
                else if (checkIsSpecial(s[end]))
                {
                    end--;
                }
                else if (s[start] == s[end])
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

        public bool checkIsSpecial(char c)
        {
            if ((c >= 97 && c <= 122) || (c >= 65 && c <= 90) || (c >= 48 && c <= 57))
                return false;

            return true;
        }
    }
}
