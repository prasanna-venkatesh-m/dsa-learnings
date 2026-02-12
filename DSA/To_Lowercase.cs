using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class To_Lowercase
    {
        public string ToLowerCase(string s)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i< s.Length; i++)
            {
                if (s[i] >= 'A' && s[i]<= 'Z')
                {
                    sb.Append((char)(s[i] + 32));
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }
    }
}
