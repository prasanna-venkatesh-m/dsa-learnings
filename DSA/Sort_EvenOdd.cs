using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Sort_EvenOdd
    {
        public int[] SortEvenOdd(int[] nums)
        {
            int n = nums.Length;
            if (n <= 1) return nums; // edge case

            int evensLength = (n + 1) / 2;
            int oddsLength = n / 2;

            int[] evens = new int[evensLength];
            int[] odds = new int[oddsLength];

            // Split nums into even and odd indices
            int eIndex = 0, oIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i & 1) == 0) evens[eIndex++] = nums[i];
                else odds[oIndex++] = nums[i];
            }

            // Find min and max for counting sort
            int minEven = evens[0], maxEven = evens[0];
            for (int i = 1; i < evensLength; i++)
            {
                if (evens[i] < minEven) minEven = evens[i];
                if (evens[i] > maxEven) maxEven = evens[i];
            }

            int minOdd = oddsLength > 0 ? odds[0] : 0;
            int maxOdd = oddsLength > 0 ? odds[0] : 0;
            for (int i = 1; i < oddsLength; i++)
            {
                if (odds[i] < minOdd) minOdd = odds[i];
                if (odds[i] > maxOdd) maxOdd = odds[i];
            }

            // Counting sort for evens (ascending)
            int rangeEven = maxEven - minEven + 1;
            int[] countEven = new int[rangeEven];
            for (int i = 0; i < evensLength; i++)
                countEven[evens[i] - minEven]++;

            int idx = 0;
            for (int i = 0; i < rangeEven; i++)
                while (countEven[i]-- > 0)
                    evens[idx++] = i + minEven;

            // Counting sort for odds (descending)
            if (oddsLength > 0)
            {
                int rangeOdd = maxOdd - minOdd + 1;
                int[] countOdd = new int[rangeOdd];
                for (int i = 0; i < oddsLength; i++)
                    countOdd[odds[i] - minOdd]++;

                idx = 0;
                for (int i = rangeOdd - 1; i >= 0; i--)
                    while (countOdd[i]-- > 0)
                        odds[idx++] = i + minOdd;
            }

            // Merge back directly
            for (int i = 0; i < evensLength; i++)
                nums[2 * i] = evens[i];

            for (int i = 0; i < oddsLength; i++)
                nums[2 * i + 1] = odds[i];

            return nums;
        }

    }
}
