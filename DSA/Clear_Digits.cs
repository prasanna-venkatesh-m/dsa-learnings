using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Clear_Digits
    {
        public string ClearDigits(string s)
        {
            var sb = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    if (sb.Length > 0)
                        sb.Length--;
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
