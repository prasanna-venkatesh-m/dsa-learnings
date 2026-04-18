using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA
{
    public class LargestTime_FromDigits
    {
        public string LargestTimeFromDigits(int[] arr)
        {
            int[] count = new int[10];
            foreach (int d in arr)
                count[d]++;

            for (int h1 = 2; h1 >= 0; h1--)
            {
                if (count[h1] == 0) continue;
                count[h1]--;

                for (int h2 = (h1 == 2 ? 3 : 9); h2 >= 0; h2--)
                {
                    if (count[h2] == 0) continue;
                    count[h2]--;

                    for (int m1 = 5; m1 >= 0; m1--)
                    {
                        if (count[m1] == 0) continue;
                        count[m1]--;

                        for (int m2 = 9; m2 >= 0; m2--)
                        {
                            if (count[m2] == 0) continue;

                            return $"{h1}{h2}:{m1}{m2}";
                        }

                        count[m1]++;
                    }

                    count[h2]++;
                }

                count[h1]++;
            }

            return "";
        }
    }
}
