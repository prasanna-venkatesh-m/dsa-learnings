using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            Stack<int> result = new Stack<int>();
            int remainder = 0;
            int val = digits[digits.Length - 1]+1;
            if (val > 9)
            {
                remainder = val / 10;
                val = val % 10;
            }
            result.Push(val);

            for (int i = digits.Length-2; i >= 0; i--)
            {
                int others = digits[i]+ remainder;
                if (others > 9)
                {
                    remainder = others / 10;
                    others = others % 10;
                }
                else
                {
                    remainder = 0;
                }
                result.Push(others);
            }
            if(remainder > 0)
            {
                result.Push(remainder);
            }

            return result.ToArray();
        }
    }
}
