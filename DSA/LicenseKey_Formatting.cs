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
            string new_s = s.Replace("-", "").ToUpper();
            int i = new_s.Length;
            while(i >= 0)
            {
                i = i - k;
                if(i > 0)
                {
                    new_s = new_s.Insert(i, "-");
                }
            }
            return new_s;
        }
    }
}
