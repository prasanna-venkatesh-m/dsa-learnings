using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Valid_Palindrome_2
    {
        public bool ValidPalindrome(string s)
        {
            for(int i=0; i< s.Length; i++)
            {
                string temp = s.Substring(0, i) + s.Substring(i+1);
                if (checkPalindrome(temp)) return true;
            }
            return false;
        }

        public bool checkPalindrome(string word)
        {
            int i = 0;
            int j = word.Length - 1;
            while(i < j)
            {
                if (word[i] == word[j])
                {
                    i++;
                    j--;
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
