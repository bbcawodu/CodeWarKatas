using System;
using System.Linq;

namespace Katas.Models
{
    /*
       Return the number (count) of vowels in the given string.
       
       We will consider a, e, i, o, and u as vowels for this Kata.
       
       The input string will only consist of lower case letters and/or spaces.
     */
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
            int totalVowelCount = vowels.Sum(
                vowel => input.Count(letter => letter == vowel)
            );

            return totalVowelCount;
        }

        public static int GetNumberOfLettersThatAreVowels(string input)
        {
            return input.Count(letter => vowels.Contains(letter));
        }
    }
}
