using System;

namespace DSA
{
    public class GuessGame
    {
        private int picked = 6;

        public int guess(int num)
        {
            if (num > picked) return -1;
            if (num < picked) return 1;
            return 0;
        }
    }

    public class Guess_Game : GuessGame
    {
        public int GuessNumber(int n)
        {
            int left = 1;
            int right = n;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int res = guess(mid);

                if (res == 0) return mid;
                else if (res == -1) right = mid - 1;
                else left = mid + 1;
            }

            return -1;
        }
    }
}