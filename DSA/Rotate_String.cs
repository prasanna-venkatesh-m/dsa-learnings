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
            return (s + s).Contains(goal);
        }
    }
}
