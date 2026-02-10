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
            int maxLen = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLen, '0');
            num2 = num2.PadLeft(maxLen, '0');

            int i = 0;
            BigInteger sum = 0;

            while (i < maxLen)
            {
                BigInteger power = (BigInteger)Math.Pow(10.00, (maxLen - i - 1));
                BigInteger first = num1[i] - '0';
                BigInteger second = num2[i] - '0';
                first = first * power;
                second = second * power;
                sum = sum + first + second;
                i++;
            }

            return sum.ToString();
        }
    }
}
