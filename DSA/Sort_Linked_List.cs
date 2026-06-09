using System;
using System.Collections.Generic;
using System.Text;
using static DSA.Merge_Sorted_Linked_List;

namespace DSA
{
    public class Sort_Linked_List
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode SortList(ListNode head)
        {
            List<int> values = new List<int>();
            ListNode temp = head;
            while (temp != null)
            {
                values.Add(temp.val);
                temp = temp.next;
            }

            values.Sort();

            ListNode res = head;
            int i = 0;
            while (res != null)
            {
                res.val = values[i++];

                res = res.next;
            }
            return head;
        }
    }
}
