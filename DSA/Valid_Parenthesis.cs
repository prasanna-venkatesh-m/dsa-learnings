using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Valid_Parenthesis
    {
        public bool IsValid(string s)
        {
            try
            {
                Stack<char> rer = new Stack<char>(s.Length);
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    {
                        rer.Push(s[i]);
                    }
                    else if (s[i] == ')' && rer.Pop() != '(')
                    {
                        return false;
                    }
                    else if (s[i] == '}' && rer.Pop() != '{')
                    {
                        return false;
                    }
                    else if (s[i] == ']' && rer.Pop() != '[')
                    {
                        return false;
                    }
                }
                return rer.Count == 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
