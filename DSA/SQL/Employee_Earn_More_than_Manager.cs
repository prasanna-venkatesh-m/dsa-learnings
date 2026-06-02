using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.SQL
{
    internal class Employee_Earn_More_than_Manager
    {
        //        Table: Employee

        //+-------------+---------+
        //| Column Name | Type    |
        //+-------------+---------+
        //| id          | int     |
        //| name        | varchar |
        //| salary      | int     |
        //| managerId   | int     |
        //+-------------+---------+
        //id is the primary key(column with unique values) for this table.
        //Each row of this table indicates the ID of an employee, their name, salary, and the ID of their manager.



        //Write a solution to find the employees who earn more than their managers.

        //Return the result table in any order.

        //The result format is in the following example.



        //Example 1:

        //Input: 
        //Employee table:
        //+----+-------+--------+-----------+
        //| id | name  | salary | managerId |
        //+----+-------+--------+-----------+
        //| 1  | Joe   | 70000  | 3         |
        //| 2  | Henry | 80000  | 4         |
        //| 3  | Sam   | 60000  | Null      |
        //| 4  | Max   | 90000  | Null      |
        //+----+-------+--------+-----------+
        //Output: 
        //+----------+
        //| Employee |
        //+----------+
        //| Joe      |
        //+----------+
        //Explanation: Joe is the only employee who earns more than his manager.

        //        SELECT
        //e.name as Employee
        //FROM Employee e
        //INNER JOIN Employee m on e.managerId = m.id
        //WHERE e.salary > m.salary

        //Solution 2:

        //        SELECT e.name AS Employee
        //FROM Employee e
        //WHERE EXISTS (
        //    SELECT 1
        //    FROM Employee m
        //    WHERE m.id = e.managerId
        //      AND e.salary > m.salary
        //);
    }
}
