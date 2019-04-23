using System;

namespace Katas.Models
{
    public class MissingLetterFinder
    {
        public static char[] alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static char[] alphabetLower = Array.ConvertAll(alphabetUpper, letter => Char.ToLower(letter));

        public static char FindMissingLetter(char[] inputArray)
        {
            var alphabetToUse = GetAlphabetToUse(inputArray);
            var alphabetStartIndex = Array.IndexOf(alphabetToUse, inputArray[0]);

            for (var i = 0; i < inputArray.Length; i += 1)
            {
                var alphabetIndex = i + alphabetStartIndex;
                if (inputArray[i] != alphabetToUse[alphabetIndex])
                {
                    return alphabetToUse[alphabetIndex];
                }
            }

            return ' ';
        }

        private static char[] GetAlphabetToUse(char[] array)
        {
            bool inputArrayIsUpper = Array.Exists(alphabetUpper, element => element == array[0]);
            var alphabetToUse = inputArrayIsUpper ? alphabetUpper : alphabetLower;
            return alphabetToUse;
        }
    }
}
