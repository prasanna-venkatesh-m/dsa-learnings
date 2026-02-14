using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Find_Difference
    {
        public char FindTheDifference(string s, string t)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i< t.Length; i++)
            {
                if (ht.ContainsKey(t[i]))
                {
                    ht[t[i]] = (int)ht[t[i]] + 1; 
                }
                else
                {
                    ht.Add(t[i], 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                ht[s[i]] = (int)ht[s[i]] - 1;
            }

            // Find the character with count 1
            foreach (DictionaryEntry entry in ht)
            {
                if ((int)entry.Value == 1)
                    return (char)entry.Key;
            }
            return '0';
        }
    }
}
