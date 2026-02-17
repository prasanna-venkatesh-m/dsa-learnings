using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Keyboard_row
    {
        public string[] FindWords(string[] words)
        {
            List<string> res = new List<string>();
            string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            foreach(string normalWord in words)
            {
                string word = normalWord.ToLower();
                bool isSameRow = true;
                int row_num = rows[0].Contains(word[0]) ? 0 : rows[1].Contains(word[0]) ? 1 : 2;
                for(int i=1; i< word.Length; i++)
                {
                    if (!rows[row_num].Contains(word[i]))
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
