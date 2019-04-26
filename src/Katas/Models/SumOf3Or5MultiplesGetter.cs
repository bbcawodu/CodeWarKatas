using System.Collections.Generic;
using System.Linq;

namespace Katas.Models
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
       
       Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
       
       Note: If the number is a multiple of both 3 and 5, only count it once.
     */
    public class SumOf3Or5MultiplesGetter
    {
        private static int _upperLimit;
        private static IEnumerable<int> _intsToSum;

        public static int Get(int upperLimit)
        {
            var sumGetter = new SumOf3Or5MultiplesGetter(upperLimit);

            return sumGetter.GetSumFromMultiples();
        }

        private SumOf3Or5MultiplesGetter(int upperLimit)
        {
            _upperLimit = upperLimit;
            _intsToSum = Enumerable.Range(0, _upperLimit)
                .Where( number => (number % 3 == 0 || number % 5 == 0));
        }

        private int GetSumFromMultiples()
        {
            return _intsToSum.Sum();
        }
    }
}
