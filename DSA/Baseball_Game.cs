using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Baseball_Game
    {
        public int CalPoints(string[] operations)
        {
            Stack<int> s = new Stack<int>();
            foreach(string operation in operations)
            {
                switch (operation)
                {
                    case "D":
                        s.Push(s.Peek() * 2);
                        break;

                    case "C":
                        s.Pop();
                        break;

                    case "+":
                        var first = s.Pop();
                        var sum = first + s.Peek();
                        s.Push(first);
                        s.Push(sum);
                        break;

                    default:
                        s.Push(int.Parse(operation));
                        break;
                }
            }
            int res = 0;
            foreach(int num in s)
            {
                res += num;
            }
            return res;
        }
    }
}
