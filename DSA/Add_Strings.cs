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

            List<int> result = new List<int>(maxLen);
            int carry = 0;

            for (int i = 0; i < maxLen; i++)
            {
                int sum = (num1[i] - '0') + (num2[i] - '0');
                result.Add(sum);
            }

            // resolve carries RIGHT → LEFT
            for (int i = maxLen - 1; i >= 0; i--)
            {
                result[i] += carry;
                carry = result[i] / 10;
                result[i] %= 10;
            }

            if (carry > 0)
                result.Insert(0, carry);

            return string.Concat(result);
        }

    }
}
