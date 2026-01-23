using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            for(int i=digits.Length-1;i>=0;i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
