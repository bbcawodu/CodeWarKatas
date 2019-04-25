using System;
using System.Collections.Generic;

namespace Katas.Models
{
    public class BinaryArrayToNumberConverter
    {
        public static int Convert(int[] binaryDigits)
        {
            var binaryStack = new Stack<int>(binaryDigits);

            return ConvertRecursively(binaryStack);
        }

        public static int ConvertRecursively(Stack<int> binaryDigits, int currentPower = 0)
        {
            if (binaryDigits.Count == 0) return 0;

            var currentBinaryDigit = binaryDigits.Pop();
            var currentBinaryValue = currentBinaryDigit == 1 ?
                (int)Math.Pow(2, currentPower) : 0;
            currentPower += 1;

            return currentBinaryValue + ConvertRecursively(binaryDigits, currentPower);
        }
    }
}
