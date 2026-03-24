using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Flower_beds
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = n;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (count == 0) return true;

                if(flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length-1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    count--;
                }
            }
            return count==0;
        }
    }
}
