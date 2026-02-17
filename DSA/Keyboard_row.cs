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
                if(word.All(c => "qwertyuiop".Contains(c)))
                {
                    res.Add(normalWord);
                }
                if (word.All(c => "asdfghjkl".Contains(c)))
                {
                    res.Add(normalWord);
                }
                if (word.All(c => "zxcvbnm".Contains(c)))
                {
                    res.Add(normalWord);
                }
            }
            return res.ToArray();
        }
    }
}
