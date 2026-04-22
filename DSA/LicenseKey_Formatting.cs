using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DSA
{
    public class LicenseKey_Formatting
    {
        public string LicenseKeyFormatting(string s, int k)
        {
            var sb = new StringBuilder();
            int count = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '-') continue;

                if (count == k)
                {
                    sb.Append('-');
                    count = 0;
                }

                sb.Append(char.ToUpper(s[i]));
                count++;
            }

            var result = sb.ToString().ToCharArray();
            Array.Reverse(result);

            return new string(result);
        }
    }
}
