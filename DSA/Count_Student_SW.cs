using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Count_Student_SW
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> stu = new Queue<int>(students);
            Queue<int> sw = new Queue<int>(sandwiches);

            while(sw.Count > 0)
            {
                if(sw.Peek() == stu.Peek())
                {
                    sw.Dequeue();
                    stu.Dequeue();
                }
                else
                {
                    int val = stu.Dequeue();
                    stu.Enqueue(val);
                }
            }

            return stu.Count;
        }
    }
}
