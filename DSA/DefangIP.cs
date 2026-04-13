using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class DefangIP
    {
        public string DefangIPaddr(string address)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in address)
            {
                if(c == '.')
                {
                    sb.Append("[.]");
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
