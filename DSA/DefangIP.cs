using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class DefangIP
    {
        public string DefangIPaddr(string address)
        {
            StringBuilder sb = new StringBuilder(address);
            sb.Replace(".", "[.]");
            return sb.ToString();
        }
    }
}
