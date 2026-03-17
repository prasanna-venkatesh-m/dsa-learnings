using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Add_Digits
    {
        public int AddDigits(int num)
        {
            while (true)
            {
                int res = 0;
                while (num > 0)
                {
                    res = res + (num % 10);
                    num /= 10;
                }
                if (res < 10)
                {
                    return res;
                }
                else
                {
                    num = res;
                }
            }
        }
    }
}
