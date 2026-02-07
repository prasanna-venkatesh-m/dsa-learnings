using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Reverse_String_2
    {
        public string ReverseStr(string s, int k)
        {
            StringBuilder sb = new StringBuilder(s);

            for (int startPosition = 0; startPosition < sb.Length; startPosition += 2 * k)
            {
                int endPosition = Math.Min(startPosition + k - 1, sb.Length - 1);

                int left = startPosition;
                int right = endPosition;

                while (left < right)
                {
                    char temp = sb[left];
                    sb[left] = sb[right];
                    sb[right] = temp;
                    left++;
                    right--;
                }
            }

            return sb.ToString();
        }
    }
}
