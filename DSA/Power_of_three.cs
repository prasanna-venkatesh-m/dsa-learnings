using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Power_of_three
    {
        public bool IsPowerOfThree(int n)
        {
            for(int i =0; i< n; i++)
            {
                if(Math.Pow(3, i) == n)
                {
                    return true; 
                }
            }
            return false;
        }
    }
}
