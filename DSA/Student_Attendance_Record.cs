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
            bool hasAbsents = s.Count(x => x == 'A') < 2;
            bool hasLate =  Regex.IsMatch(s, "LLL");
            return hasAbsents && !hasLate;
        }
    }
}
