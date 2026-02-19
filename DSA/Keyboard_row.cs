using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA
{
    public class Keyboard_row
    {
        private static readonly byte[] map = new byte[128];

        static Keyboard_row()
        {
            string row1 = "qwertyuiopQWERTYUIOP";
            string row2 = "asdfghjklASDFGHJKL";
            string row3 = "zxcvbnmZXCVBNM";

            foreach (char c in row1) map[c] = 1;
            foreach (char c in row2) map[c] = 2;
            foreach (char c in row3) map[c] = 3;
        }

        public string[] FindWords(string[] words)
        {
            var result = new List<string>(words.Length);

            foreach (var word in words)
            {
                byte row = map[word[0]];
                bool valid = true;

                for (int i = 1; i < word.Length; i++)
                {
                    if (map[word[i]] != row)
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