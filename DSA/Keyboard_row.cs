using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA
{
    public class Keyboard_row
    {
        public string[] FindWords(string[] words)
        {
            HashSet<char> row1 = new HashSet<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            HashSet<char> row2 = new HashSet<char>() { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            HashSet<char> row3 = new HashSet<char>() { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            List<string> res = new List<string>();
            foreach(string normalWord in words)
            {
                string word = normalWord.ToLower();
                HashSet<char> targetRow = null;
                bool isSameRow = true;

                if (row1.Contains(word[0])) targetRow = row1;
                else if(row2.Contains(word[0])) targetRow = row2;
                else if (row3.Contains(word[0])) targetRow = row3;

                foreach(char c in word)
                {
                    if (!targetRow.Contains(c))
                    {
                        isSameRow = false;
                        break;
                    }
                }
                if (isSameRow)
                {
                    res.Add(normalWord);
                }
            }
            return res.ToArray();
        }
    }
}
