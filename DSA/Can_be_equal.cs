using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Can_be_equal
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            if (target.Length != arr.Length)
                return false;

            Hashtable ht = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                if (ht.ContainsKey(arr[i]))
                    ht[arr[i]] = (int)ht[arr[i]] + 1;
                else
                    ht[arr[i]] = 1;
            }

            for (int i = 0; i < target.Length; i++)
            {
                if (!ht.ContainsKey(target[i]))
                    return false;

                ht[target[i]] = (int)ht[target[i]] - 1;

                if ((int)ht[target[i]] == 0)
                    ht.Remove(target[i]);
            }

            return ht.Count == 0;
        }
    }
}
