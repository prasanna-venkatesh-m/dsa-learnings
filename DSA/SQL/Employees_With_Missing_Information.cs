using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Emit;
using System.Text;

namespace DSA.SQL
{
    internal class Employees_With_Missing_Information
    {
        //Table: Employees

        //+-------------+---------+
        //| Column Name | Type    |
        //+-------------+---------+
        //| employee_id | int     |
        //| name        | varchar |
        //+-------------+---------+
        //employee_id is the column with unique values for this table.
        //Each row of this table indicates the name of the employee whose ID is employee_id.


        //Table: Salaries

        //+-------------+---------+
        //| Column Name | Type    |
        //+-------------+---------+
        //| employee_id | int     |
        //| salary      | int     |
        //+-------------+---------+
        //employee_id is the column with unique values for this table.
        //Each row of this table indicates the salary of the employee whose ID is employee_id.

        //SELECT
        //e.employee_id FROM
        //Employees e
        //LEFT JOIN Salaries s on e.employee_id = s.employee_id
        //WHERE s.employee_id IS NULL

        //UNION

        //SELECT
        //s.employee_id FROM
        //Salaries s
        //LEFT JOIN Employees e on s.employee_id = e.employee_id
        //WHERE e.employee_id IS NULL
    }
    }
