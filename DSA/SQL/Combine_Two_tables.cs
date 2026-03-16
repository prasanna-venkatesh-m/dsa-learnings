using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.SQL
{
    internal class Combine_Two_tables
    {

            //        Write a solution to report the first name, last name, city, and state of each person in the Person table.If the address of a personId is not present in the Address table, report null instead.
            //Return the result table in any order.
            //The result format is in the following example.

            //Example 1:

            //Input: 
            //Person table:
            //+----------+----------+-----------+
            //| personId | lastName | firstName |
            //+----------+----------+-----------+
            //| 1        | Wang     | Allen     |
            //| 2        | Alice    | Bob       |
            //+----------+----------+-----------+
            //Address table:
            //+-----------+----------+---------------+------------+
            //| addressId | personId | city          | state      |
            //+-----------+----------+---------------+------------+
            //| 1         | 2        | New York City | New York   |
            //| 2         | 3        | Leetcode      | California |
            //+-----------+----------+---------------+------------+
            //Output: 
            //+-----------+----------+---------------+----------+
            //| firstName | lastName | city          | state    |
            //+-----------+----------+---------------+----------+
            //| Allen     | Wang     | Null          | Null     |
            //| Bob       | Alice    | New York City | New York |
            //+-----------+----------+---------------+----------+
            //Explanation: 
            //There is no address in the address table for the personId = 1 so we return null in their city and state.
            //addressId = 1 contains information about the address of personId = 2.


        /* Write your T-SQL query statement below */
        //SELECT p.firstName, p.lastName, a.city, a.state
        //FROM Person p
        //LEFT JOIN Address a on p.personId = a.personId
    }
}
