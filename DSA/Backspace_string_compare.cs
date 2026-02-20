using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Backspace_string_compare
    {
        public bool BackspaceCompare(string s, string t)
        {
            Stack<char> s1 = new Stack<char>();
            Stack<char> s2 = new Stack<char>();
            int i = 0;
            while(i < s.Length && i < t.Length)
            {
                if (s[i] == '#')
                {
                    if(s1.Count > 0)
                    s1.Pop();
                }
                else
                {
                    s1.Push(s[i]);
                }

                if (t[i] == '#')
                {
                    if(s2.Count > 0)
                    s2.Pop();
                }
                else
                {
                    s2.Push(t[i]);
                }
                i++;
            }
            while(i < s.Length)
            {
                if (s[i] == '#')
                {
                    if(s1.Count > 0)
                    s1.Pop();
                }
                else
                {
                    s1.Push(s[i]);
                }
                i++;
            }
            while( i < t.Length)
            {
                if (t[i] == '#')
                {
                    if(s2.Count > 0)
                    s2.Pop();
                }
                else
                {
                    s2.Push(t[i]);
                }
                i++;
            }
            return s1.SequenceEqual(s2);
        }
    }   
}
