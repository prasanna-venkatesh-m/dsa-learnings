using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.SQL
{
    internal class Patient_With_Condition
    {
        //        Table: Patients

        //+--------------+---------+
        //| Column Name  | Type    |
        //+--------------+---------+
        //| patient_id   | int     |
        //| patient_name | varchar |
        //| conditions   | varchar |
        //+--------------+---------+
        //patient_id is the primary key(column with unique values) for this table.
        //'conditions' contains 0 or more code separated by spaces.
        //This table contains information of the patients in the hospital.



        //Write a solution to find the patient_id, patient_name, and conditions of the patients who have Type I Diabetes. Type I Diabetes always starts with DIAB1 prefix.

        //Return the result table in any order.

        //The result format is in the following example.



        //Example 1:

        //Input: 
        //Patients table:
        //+------------+--------------+--------------+
        //| patient_id | patient_name | conditions   |
        //+------------+--------------+--------------+
        //| 1          | Daniel       | YFEV COUGH   |
        //| 2          | Alice        |              |
        //| 3          | Bob          | DIAB100 MYOP |
        //| 4          | George       | ACNE DIAB100 |
        //| 5          | Alain        | DIAB201      |
        //+------------+--------------+--------------+
        //Output: 
        //+------------+--------------+--------------+
        //| patient_id | patient_name | conditions   |
        //+------------+--------------+--------------+
        //| 3          | Bob          | DIAB100 MYOP |
        //| 4          | George       | ACNE DIAB100 | 
        //+------------+--------------+--------------+
        //Explanation: Bob and George both have a condition that starts with DIAB1.

        //        SELECT
        //*
        //FROM Patients
        //WHERE conditions LIKE 'DIAB1%' 
        //OR conditions LIKE '% DIAB1%' 

    }
}
