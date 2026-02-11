using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Unique_Morse_Code
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            HashSet<string> res = new HashSet<string>();
            foreach(string word in words)
            {
                string code = "";
                for(int i = 0; i < word.Length; i++)
                {
                    code = code + morse[word[i] - 97];
                }
                res.Add(code);
            }
            return res.Count();
        }
    }
}
