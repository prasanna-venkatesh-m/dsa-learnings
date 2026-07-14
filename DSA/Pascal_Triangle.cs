using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Pascal_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> lists = new List<IList<int>>(numRows);
            for(int i=1; i<= numRows; i++)
            {
                lists.Add(giveList(i));
            }
            
            for (int i = 2; i < numRows; i++)
            {
                for(int k = 1; k < lists[i].Count - 1; k++)
                {
                    lists[i][k] = lists[i - 1][k - 1] + lists[i - 1][k];
                }
            }
            return lists;
        }
        private IList<int> giveList(int size)
        {
            List<int> list = new List<int>(new int[size]);
            list[0] = 1;
            list[size - 1] = 1;
            return list;
        }
    }
}
