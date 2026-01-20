using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DSA
{
    public class Third_Maximum_Number
    {
        public int ThirdMax(int[] nums)
        {
            long max = long.MinValue;
            long second_max = long.MinValue;
            long third_max = long.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int numb = nums[i];
                if (numb >= max)
                {
                    if (max != numb)
                    {
                        third_max = second_max;
                        second_max = max;
                        max = numb;
                    }
                }
                else if (numb >= second_max)
                {
                    if (second_max != numb)
                    {
                        third_max = second_max;
                        second_max = numb;
                    }
                }
                else if (numb >= third_max)
                {
                    if (third_max != numb)
                    {
                        third_max = numb;
                    }
                }
            }
            return (nums.Length < 3 || third_max == long.MinValue) ? (int)max : (int)third_max;
        }
    }
}
