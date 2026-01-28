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

            //DuplicateCheck dup = new DuplicateCheck();
            //Console.WriteLine(dup.ContainsDuplicate([1, 2, 3, 4]));

            //Third_Maximum_Number tmn = new Third_Maximum_Number();
            //Console.WriteLine(tmn.ThirdMax([3,2,1]).ToString());

            // Reverse_Integer rev = new Reverse_Integer();
            // Console.WriteLine(rev.Reverse(-123).ToString());

            //Plus_One po = new Plus_One();
            //var res = po.PlusOne([7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6]);
            //foreach(var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //Lastword_Length leng = new Lastword_Length();
            //Console.WriteLine(leng.LengthOfLastWord("   fly me   to   the moon  "));

            //Single_Number sn = new Single_Number();
            //Console.WriteLine(sn.SingleNumber([4, 1, 2, 1, 2]).ToString());

            // Majority_Element me = new Majority_Element();
            // Console.WriteLine(me.MajorityElement([2, 2, 1, 1, 1, 2, 2]).ToString());

            //MergeSortedArray ms = new MergeSortedArray();
            //ms.Merge([4, 0, 0, 0, 0, 0], 1, [1, 2, 3, 5, 6], 5);

            MoveZeros mz = new MoveZeros();
            mz.MoveZeroes([4, 2, 4, 0, 0, 3, 0, 5, 1, 0]);
        }
    }
}
