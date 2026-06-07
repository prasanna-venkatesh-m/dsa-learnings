using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.SQL
{
    internal class Customer_Placing_Largest_Order
    {
        //        Table: Orders

        //+-----------------+----------+
        //| Column Name     | Type     |
        //+-----------------+----------+
        //| order_number    | int      |
        //| customer_number | int      |
        //+-----------------+----------+
        //order_number is the primary key(column with unique values) for this table.
        //This table contains information about the order ID and the customer ID.


        //Write a solution to find the customer_number for the customer who has placed the largest number of orders.

        //The test cases are generated so that exactly one customer will have placed more orders than any other customer.

        //The result format is in the following example.



        //Example 1:

        //Input: 
        //Orders table:
        //+--------------+-----------------+
        //| order_number | customer_number |
        //+--------------+-----------------+
        //| 1            | 1               |
        //| 2            | 2               |
        //| 3            | 3               |
        //| 4            | 3               |
        //+--------------+-----------------+
        //Output: 
        //+-----------------+
        //| customer_number |
        //+-----------------+
        //| 3               |
        //+-----------------+
        //Explanation: 
        //The customer with number 3 has two orders, which is greater than either customer 1 or 2 because each of them only has one order. 
        //So the result is customer_number 3.

        //        SELECT
        //TOP(1) customer_number
        //FROM Orders
        //GROUP By customer_number
        //ORDER BY COUNT(*) DESC

        //        WITH cte AS(
        //    SELECT customer_number, COUNT(*) cnt
        //    FROM Orders
        //    GROUP BY customer_number
        //)
        //SELECT TOP 1 customer_number
        //FROM cte
        //ORDER BY cnt DESC;

    }
}
