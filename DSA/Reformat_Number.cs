using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Reformat_Number
    {
        public string ReformatNumber(string number)
        {
            StringBuilder digits = new StringBuilder();

            foreach (char c in number)
            {
                if (char.IsDigit(c))
                    digits.Append(c);
            }

            StringBuilder result = new StringBuilder();
            int i = 0;
            int n = digits.Length;

            while (n - i > 0)
            {
                if (n - i > 4)
                {
                    for (int j = 0; j < 3; j++)
                        result.Append(digits[i++]);

                    result.Append('-');
                }
                else if (n - i == 4)
                {
                    for (int j = 0; j < 2; j++)
                        result.Append(digits[i++]);

                    result.Append('-');

                    for (int j = 0; j < 2; j++)
                        result.Append(digits[i++]);

                    break;
                }
                else
                {
                    while (i < n)
                        result.Append(digits[i++]);

                    break;
                }
            }

            return result.ToString();
        }
    }
}
