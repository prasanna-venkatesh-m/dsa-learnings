using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class TitleToNumbers
    {
        public int TitleToNumber(string columnTitle)
        {
            double res = 0;
            int length = columnTitle.Length;
            for (int i = length-1; i >= 0; i--)
            {
                res += (Math.Pow(26, length - i-1)) + (columnTitle[i] - 65);
            }
            return (int)res;
        }
    }
}
