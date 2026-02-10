using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Second_Highest_Digit
    {
        public int SecondHighest(string s)
        {
            int max = -1;
            int secondMax = -1;

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] > 47 && s[i] < 58)
                {
                    int num = s[i] - '0';
                    if(num == max)
                    {
                        continue;
                    }
                    else if(num > max)
                    {
                        secondMax = max;
                        max = num;
                    }
                    else if(num > secondMax)
                    {
                        secondMax = num;
                    }
                }
            }
            return secondMax;
        }
    }
}
