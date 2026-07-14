using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DSA
{
    public class Pascal_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>(numRows);

            for (int i = 0; i < numRows; i++)
            {
                var row = new List<int>(i + 1);

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(((List<int>)result[i - 1])[j - 1] + ((List<int>)result[i - 1])[j]);
                    }
                }

                result.Add(row);
            }

            return result;
        }
    }
}
