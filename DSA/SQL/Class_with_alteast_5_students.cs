using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Emit;
using System.Text;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.SQL
{
    internal class Class_with_alteast_5_students
    {

        //        +-------------+---------+
        //| Column Name | Type    |
        //+-------------+---------+
        //| student     | varchar |
        //| class       | varchar |
        //+-------------+---------+
        //(student, class) is the primary key(combination of columns with unique values) for this table.
        //Each row of this table indicates the name of a student and the class in which they are enrolled.


        //Write a solution to find all the classes that have at least five students.

        //Return the result table in any order.

        //The result format is in the following example.



        //Example 1:

        //Input: 
        //Courses table:
        //+---------+----------+
        //| student | class    |
        //+---------+----------+
        //| A       | Math     |
        //| B       | English  |
        //| C       | Math     |
        //| D       | Biology  |
        //| E       | Math     |
        //| F       | Computer |
        //| G       | Math     |
        //| H       | Math     |
        //| I       | Math     |
        //+---------+----------+
        //Output: 
        //+---------+
        //| class   |
        //+---------+
        //| Math    |
        //+---------+
        //Explanation: 
        //- Math has 6 students, so we include it.
        //- English has 1 student, so we do not include it.
        //- Biology has 1 student, so we do not include it.
        //- Computer has 1 student, so we do not include it.


        //SELECT
        //class
        //FROM Courses
        //GROUP BY class
        //HAVING COUNT(*)>4
    }
}
