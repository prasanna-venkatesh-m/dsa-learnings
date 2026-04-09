using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Sum_Multiples
    {
        public int SumOfMultiples(int n)
        {
            var res = 0;
            for(int i=1; i<=n; i++)
            {
                if (i % 3 == 0) res += i; 
                else if(i % 5 == 0) res += i;
                else if (i % 7 == 0) res += i;
            }
            return res;
        }
    }
}
