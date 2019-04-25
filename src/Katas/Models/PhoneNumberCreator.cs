using System;
using System.Collections.Generic;

namespace Katas.Models
{
    /*
        Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
       
       Example:
       Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
       The returned format must be correct in order to complete this challenge. 
       Don't forget the space after the closing parentheses!
     */
    public class PhoneNumberCreator
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            var areaCode = BuildAreaCode(numbers);
            var restOfNumber = BuildPhoneNumberSuffix(numbers);
            return $@"({areaCode}) {restOfNumber}";
        }

        private static string BuildAreaCode(int[] numbers)
        {
            int[] areaCodeSlice = new int[3];

            Array.Copy(numbers, 0, areaCodeSlice, 0, 3);
            return $@"{string.Join("", areaCodeSlice)}";
        }

        private static string BuildPhoneNumberSuffix(int[] numbers)
        {
            var suffixParts = new List<int[]>
            {
                new int[3],
                new int[4]
            };

            Array.Copy(numbers, 3, suffixParts[0], 0, 3);
            Array.Copy(numbers, 6, suffixParts[1], 0, 4);
            return $@"{string.Join("", suffixParts[0])}-{string.Join("", suffixParts[1])}";
        }
    }
}
