using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Reverse_Integer
    {
        public int Reverse(int x)
        {
            long result = 0;
            while(x != 0)
            {
                result = result * 10 + x % 10;
                x = x / 10;

                if((result > Int32.MaxValue || result < Int32.MinValue))
                {
                    return 0;
                }
            }
            return (int)result;
        }
    }
}
