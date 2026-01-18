using System;
using System.Collections.Generic;
using System.Text;

/*
9. Palindrome Number
-------------------
Difficulty: Easy

Problem:
Given an integer x, return true if x is a palindrome, and false otherwise.

An integer is a palindrome when it reads the same forward and backward.

Examples:

Example 1:
Input: x = 121
Output: true
Explanation: 121 reads the same from left to right and right to left.

Example 2:
Input: x = -121
Output: false
Explanation: From left to right it is -121, but from right to left it is 121-.

Example 3:
Input: x = 10
Output: false
Explanation: Reads 01 from right to left, which is not the same.

Constraints:
-2^31 <= x <= 2^31 - 1

Follow-up:
Can you solve this problem without converting the integer to a string?
*/

namespace DSA.Arrays
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int x_copy = x;
            int result = 0;
            while (x_copy > 0)
            {
                result *= 10;
                result += (x_copy % 10);
                x_copy = x_copy / 10;
            }
            return x == result;
        }
    }
}
