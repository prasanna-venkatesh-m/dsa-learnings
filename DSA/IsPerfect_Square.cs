using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class IsPerfect_Square
    {
        public bool IsPerfectSquare(int num)
        {
            int start = 1;
            int end = num;

            while (start <= end)
            {
                long mid = start + (end - start) / 2;
                long square = mid * mid;

                if (square == num)
                {
                    return true;
                }
                else if (square > num)
                {
                    end = (int)mid - 1;
                }
                else
                {
                    start = (int)mid + 1;
                }
            }

            return false;
        }
    }
}
