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
            int len = 0;

            foreach (char c in s)
                if (c != '-') len++;

            int dashCount = (len - 1) / k;
            int finalLen = len + dashCount;

            char[] result = new char[finalLen];

            int i = s.Length - 1;
            int j = finalLen - 1;
            int group = 0;

            while (i >= 0)
            {
                if (s[i] == '-')
                {
                    i--;
                    continue;
                }

                if (group == k)
                {
                    result[j--] = '-';
                    group = 0;
                }

                result[j--] = char.ToUpper(s[i]);
                group++;
                i--;
            }

            return new string(result);
        }
    }
}
