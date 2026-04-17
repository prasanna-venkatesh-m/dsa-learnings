using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA
{
    public class LargestTime_FromDigits
    {
        public string LargestTimeFromDigits(int[] arr)
        {
            var result = GetPermutations(arr);
            string[] actual = new string[result.Count];
            for(int i=0; i<result.Count; i++)
            {
                actual[i] = string.Join("", result[i]);
            }

            var res = actual
                    .Where(x =>
                    {
                        int hours = int.Parse(x.Substring(0, 2));
                        int mins = int.Parse(x.Substring(2, 2));
                        return hours < 24 && mins < 60;
                    })
                    .OrderByDescending(x => int.Parse(x))
                    .FirstOrDefault(); 
            return res?.Insert(2,":") ?? "";
        }
        static List<List<int>> GetPermutations(int[] nums)
        {
            var result = new List<List<int>>();
            Permute(nums, 0, result);
            return result;
        }

        static void Permute(int[] nums, int start, List<List<int>> result)
        {
            if (start == nums.Length)
            {
                // Add a copy of the array to result
                result.Add(new List<int>(nums));
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                Swap(nums, start, i);
                Permute(nums, start + 1, result);
                Swap(nums, start, i); // backtrack
            }
        }

        static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
