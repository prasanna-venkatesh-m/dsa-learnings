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
                Stack<char> rer = new Stack<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    {
                        rer.Push(s[i]);
                    }
                    else
                    {
                        if (s[i] == ')' && rer.Peek() == '(')
                        {
                            rer.Pop();
                        }
                        else if (s[i] == '}' && rer.Peek() == '{')
                        {
                            rer.Pop();
                        }
                        else if (s[i] == ']' && rer.Peek() == '[')
                        {
                            rer.Pop();
                        }
                        else
                        {
                            rer.Push(s[i]);
                        }
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
