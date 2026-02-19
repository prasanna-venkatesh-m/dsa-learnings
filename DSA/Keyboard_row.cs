using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA
{
    public class Keyboard_row
    {
        private static readonly int[] map = new int[26]
        {
            // a  b  c  d  e  f  g  h  i  j  k  l  m
               2, 3, 3, 2, 1, 2, 2, 2, 1, 2, 2, 2, 3,
            // n  o  p  q  r  s  t  u  v  w  x  y  z
               3, 1, 1, 1, 1, 2, 1, 1, 3, 1, 3, 1, 3
        };

        public string[] FindWords(string[] words)
        {
            var result = new List<string>();

            foreach (var word in words)
            {
                int firstRow = map[char.ToLower(word[0]) - 'a'];
                bool valid = true;

                for (int i = 1; i < word.Length; i++)
                {
                    if (map[char.ToLower(word[i]) - 'a'] != firstRow)
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                    result.Add(word);
            }

            return result.ToArray();
        }
    }
}