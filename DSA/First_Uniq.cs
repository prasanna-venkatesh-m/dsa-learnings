using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class First_Uniq
    {
        public int FirstUniqChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == s[i] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
