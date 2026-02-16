using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Rotate_String
    {
        public bool RotateString(string s, string goal)
        {
            if(s == goal)
            {
                return true;
            }

            for(int i=1; i< s.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                int j = i;
                while (j < s.Length)
                {
                    sb.Append(s[j]);
                    j++;
                }
                for(int k = 0; k < i; k++)
                {
                    sb.Append(s[k]);
                }

                if(goal == sb.ToString())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
