using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class DefangIP
    {
        public string DefangIPaddr(string address)
        {
           return address.Replace(".", "[.]");
        }
    }
}
