using System.Collections.Generic;
using System.Linq;

namespace Katas.Models
{
    /*
     * Given an array, find the int that appears an odd number of times.

       There will always be only one integer that appears an odd number of times.

     */
    public class OddTimesIntFinder
    {
        private static Dictionary<int, int> numbersWithOccurrences;
        private static int targetedNumber = -1;

        public static int Get(int[] numbers)
        {
            PopulateNumbersWithOccurrences(numbers);
            FindTargetedNumber();

            return targetedNumber;
        }

        private static void PopulateNumbersWithOccurrences(int[] numbers)
        {
            numbersWithOccurrences = new Dictionary<int, int>();

            numbers.ToList().ForEach(number =>
                {
                    if (!numbersWithOccurrences.ContainsKey(number))
                    {
                        numbersWithOccurrences.Add(number, 1);
                    }
                    else
                    {
                        numbersWithOccurrences[number] += 1;
                    }
                }
            );
        }

        private static void FindTargetedNumber()
        {
            foreach (var (number, occurrences) in numbersWithOccurrences)
            {
                if (occurrences%2 != 0)
                {
                    targetedNumber = number;
                    return;
                }
            }
        }
    }
}
