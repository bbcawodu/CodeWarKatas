using System;

namespace Katas.Models
{
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
