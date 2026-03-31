using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class FizzBuss
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> answer = new List<string>();
            int count3 = 0;
            int count5 = 0;

            for (int i = 1; i <= n; i++)
            {
                count3++;
                count5++;
                string res = string.Empty;

                if (count3 == 3)
                {
                    res += "Fizz";
                    count3 = 0;
                }

                if (count5 == 5)
                {
                    res += "Buzz";
                    count5 = 0;
                }

                if (string.IsNullOrEmpty(res))
                    res = i.ToString();

                answer.Add(res);
            }

            return answer;
        }
    }
}
