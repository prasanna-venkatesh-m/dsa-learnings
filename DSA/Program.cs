using DSA.Arrays;
using DSA.Duplicate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());
            //Solution sln = new Solution();
            //Console.WriteLine(sln.IsPalindrome(x));

            DuplicateCheck dup = new DuplicateCheck();
            Console.WriteLine(dup.ContainsDuplicate([1, 2, 3, 4]));
        }
    }
}
