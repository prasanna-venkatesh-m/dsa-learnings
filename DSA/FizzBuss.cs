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
            for(int i = 1; i <= n; i++)
            {
                string res = string.Empty;
                if (i % 3 == 0) res += "Fizz";
                if (i % 5 == 0) res += "Buzz";

                if (!string.IsNullOrEmpty(res)) answer.Add(res);
                else answer.Add(i.ToString());
            }
            return answer;
        }
    }
}
