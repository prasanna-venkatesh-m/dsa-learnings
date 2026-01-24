using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Lastword_Length
    {
        public int LengthOfLastWord(string s)
        {
            string[] words = s.TrimEnd().Split(' ');
            return words[words.Length-1].Length;
        }
    }
}
