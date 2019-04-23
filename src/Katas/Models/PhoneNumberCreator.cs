using System;

namespace Katas.Models
{
    public class PhoneNumberCreator
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            var areaCode = BuildAreaCodeFromArray(numbers);
            var restOfNumber = BuildPhoneNumberSuffixFromArray(numbers);
            return $@"({areaCode}) {restOfNumber}";
        }

        private static string BuildAreaCodeFromArray(int[] numbers)
        {
            int[] areaCodeSlice = new int[3];

            Array.Copy(numbers, 0, areaCodeSlice, 0, 3);
            return $@"{string.Join("", areaCodeSlice)}";
        }

        private static string BuildPhoneNumberSuffixFromArray(int[] numbers)
        {
            int[] suffixFirstPart = new int[3];
            int[] suffixSecondPart = new int[4];

            Array.Copy(numbers, 3, suffixFirstPart, 0, 3);
            Array.Copy(numbers, 6, suffixSecondPart, 0, 4);
            return $@"{string.Join("", suffixFirstPart)}-{string.Join("", suffixSecondPart)}";
        }
    }
}
