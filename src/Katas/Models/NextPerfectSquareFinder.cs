using System;

namespace Katas.Models
{
    public class NextPerfectSquareFinder
    {
        public static long FindNextPerfectSquare(long num)
        {
            if (!IsPerfectSquare(num))
            {
                return -1;
            }
            while (true)
            {
                num += 1;
                if (IsPerfectSquare(num))
                {
                    return num;
                }
            }
        }

        private static bool IsPerfectSquare(long num)
        {
            var sqrtOfNum = (decimal)Math.Sqrt(num);
            return (sqrtOfNum == Math.Floor(sqrtOfNum));
        }
    }
}
