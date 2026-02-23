using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DSA
{
    public class Student_Attendance_Record
    {
        public bool CheckRecord(string s)
        {
            int absents = 0;
            int consecutiveL = 0;

            foreach (char c in s)
            {
                if (c == 'A')
                {
                    absents++;
                    if (absents >= 2)
                        return false;
                }

                if (c == 'L')
                {
                    consecutiveL++;
                    if (consecutiveL >= 3)
                        return false;
                }
                else
                {
                    consecutiveL = 0;
                }
            }

            return true;
        }
    }
}
