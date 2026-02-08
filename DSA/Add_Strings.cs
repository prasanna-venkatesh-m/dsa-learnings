using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DSA
{
    public class Add_Strings
    {
        public string AddStrings(string num1, string num2)
        {
            BigInteger a = BigInteger.Parse(num1);
            BigInteger b = BigInteger.Parse(num2);
            return (a + b).ToString();
        }
    }
}
