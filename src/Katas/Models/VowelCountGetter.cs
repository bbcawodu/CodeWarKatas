using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Katas.Models
{
    public class VowelCountGetter
    {
        private static readonly string vowels = "aeiou";

        public static int GetVowelCount(string input)
        {
            return GetSumOfIndividualVowelCount(input);
        }

        // the count of vowels in an input string is either:
        // the sum of the count of each individual vowel that is in the input
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

        // the number of letters in the string that are a vowel
        public static int GetNumberOfLettersThatAreVowel(string input)
        {
            return input.Count(letter => vowels.Contains(letter));
        }
    }
}
