using System;
using System.Reflection.Metadata.Ecma335;

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
        private static readonly char[] alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static char[] alphabetToUse;
        private static int alphabetStartIndex;
        private static char missingLetter = ' ';

        public static char FindMissingLetter(char[] input)
        {
            GetAlphabetToUse(input);
            GetAlphabetStartIndexFrom(input);
            SearchForMissingLetter(input);

            return missingLetter;
        }

        private static void GetAlphabetToUse(char[] input)
        {
            var inputContainsUpperCase = Array.Exists(alphabetUpper, element => element == input[0]);
            alphabetToUse = inputContainsUpperCase ?
                alphabetUpper :
                Array.ConvertAll(alphabetUpper, letter => Char.ToLower(letter));
        }

        private static void GetAlphabetStartIndexFrom(char[] input)
        {
            alphabetStartIndex = Array.IndexOf(alphabetToUse, input[0]);
        }

        private static void SearchForMissingLetter(char[] input)
        {
            for (var i = 0; i < input.Length; i += 1)
            {
                var alphabetIndex = i + alphabetStartIndex;
                if (input[i] != alphabetToUse[alphabetIndex])
                {
                    missingLetter = alphabetToUse[alphabetIndex];
                }
            }
        }
    }
}
