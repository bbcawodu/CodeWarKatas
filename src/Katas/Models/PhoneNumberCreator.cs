using System;
using System.Collections.Generic;

namespace Katas.Models
{
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
