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
            StringBuilder sb = new StringBuilder();
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int carry = 0;

            while (i >= 0 && j >= 0)
            {
                int first = num1[i--] - '0';
                int second = num2[j--] - '0';
                int sum = carry + first + second;
                if (sum > 9)
                {
                    sb.Insert(0, sum % 10);
                    carry = sum / 10;
                }
                else
                {
                    sb.Insert(0, sum);
                    carry = 0;
                }
            }

            while (i >= 0)
            {
                int first = num1[i--] - '0';
                int sum = carry + first;
                if (sum > 9)
                {
                    sb.Insert(0, sum % 10);
                    carry = sum / 10;
                }
                else
                {
                    sb.Insert(0, sum);
                    carry = 0;
                }
            }

            while(j >= 0)
            {
                int first = num2[j--] - '0';
                int sum = carry + first;
                if (sum > 9)
                {
                    sb.Insert(0, sum % 10);
                    carry = sum / 10;
                }
                else
                {
                    sb.Insert(0, sum);
                    carry = 0;
                }
            }

            if (carry != 0)
            {
                sb.Insert(0, carry);
            }

            return sb.ToString();

        }
    }
}
