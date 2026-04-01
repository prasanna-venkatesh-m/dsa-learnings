using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Goat_Latin
    {
        public string ToGoatLatin(string sentence)
        {
            string[] words = sentence.Split(" ");
            char[] vowels = ['a', 'e','i','o','u'];
            string[] res = new string[words.Length];
            for(int i=0; i < words.Length; i++)
            {
                StringBuilder word = new StringBuilder(words[i]);
                if (vowels.Contains(char.ToLower(word[0])))
                {
                    word.Append("ma");
                }
                else
                {
                    word.Append(word[0] + "ma");
                    word.Remove(0,1);
                }
                for (int j = 0; j < i + 1; j++)
                {
                    word.Append('a');
                }
                res[i] = word.ToString();
            }
            return string.Join(" ", res);
        }
    }
}
