using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Clear_Digits
    {
        public string ClearDigits(string s)
        {
            Stack<char> st = new Stack<char>();
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    if(st.Count > 0)
                    {
                        st.Pop();
                    }
                }
                else
                {
                    st.Push(s[i]);
                }
            }

            return new string(st.Reverse().ToArray());
        }
    }
}
