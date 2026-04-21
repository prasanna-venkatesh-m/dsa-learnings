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
            StringBuilder sb = new StringBuilder();
            int reset = 0;
            int i = s.Length - 1;
            while (i >= 0)
            {
                if (reset == k && s[i]!='-') {
                    sb.Insert(0, '-');
                    reset = 0;
                }

                if (s[i] == '-') i--;
                else
                {
                    sb.Insert(0, char.ToUpper(s[i]));
                    i--;
                    reset++;
                }
            }
            return sb.ToString();
        }
    }
}
