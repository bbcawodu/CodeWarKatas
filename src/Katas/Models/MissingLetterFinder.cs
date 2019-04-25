using System;

namespace Katas.Models
{
    /*
     * #Find the missing letter
       
       Write a method that takes an array of consecutive (increasing) letters as input and that returns the missing letter in the array.
       
       You will always get an valid array. And it will be always exactly one letter be missing. The length of the array will always be at least 2.
       The array will always contain letters in only one case.
       
       Example:
       
       ['a','b','c','d','f'] -> 'e'
       ['O','Q','R','S'] -> 'P'
       (Use the English alphabet with 26 letters!)
     */
    public class MissingLetterFinder
    {
        public static char[] alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static char[] alphabetLower = Array.ConvertAll(alphabetUpper, letter => Char.ToLower(letter));

        public static char FindMissingLetter(char[] input)
        {
            var alphabetToUse = GetAlphabetToUse(input);
            var alphabetStartIndex = Array.IndexOf(alphabetToUse, input[0]);

            for (var i = 0; i < input.Length; i += 1)
            {
                var alphabetIndex = i + alphabetStartIndex;
                if (input[i] != alphabetToUse[alphabetIndex])
                {
                    return alphabetToUse[alphabetIndex];
                }
            }

            return ' ';
        }

        private static char[] GetAlphabetToUse(char[] input)
        {
            var inputContainsUpperCase = Array.Exists(alphabetUpper, element => element == input[0]);
            var alphabetToUse = inputContainsUpperCase ? alphabetUpper : alphabetLower;
            return alphabetToUse;
        }
    }
}
