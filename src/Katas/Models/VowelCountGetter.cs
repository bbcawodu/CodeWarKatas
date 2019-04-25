using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Katas.Models
{
    public class VowelCountGetter
    {
        private static readonly string vowels = "aeiou";

        public static int GetVowelCount(string input)
        {
            bool vowelsInWordDefinitionsAreEqual =
                GetSumOfIndividualVowelCount(input) ==
                GetNumberOfLettersThatAreVowels(input);

            if (!vowelsInWordDefinitionsAreEqual)
            {
                throw new Exception("Panic! Math is wrong.");
            }
            return GetSumOfIndividualVowelCount(input);
        }

        public static int GetSumOfIndividualVowelCount(string input)
        {
            int totalVowelCount = 0;

            foreach (var vowel in vowels)
            {
                var vowelCount = input.Count(letter => letter == vowel);
                totalVowelCount += vowelCount;
            }

            return totalVowelCount;
        }

        public static int GetNumberOfLettersThatAreVowels(string input)
        {
            return input.Count(letter => vowels.Contains(letter));
        }
    }
}
