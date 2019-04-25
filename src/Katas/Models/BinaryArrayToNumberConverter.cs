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

        public static int ConvertRecursively(Stack<int> binaryDigits, int currentIteration = 0)
        {
            if (binaryDigits.Count == 0) return 0;

            var currentBinaryDigit = binaryDigits.Pop();
            var currentPower = (int) Math.Pow(2, currentIteration);
            var currentBinaryValue = currentPower * currentBinaryDigit;
            currentIteration += 1;

            return currentBinaryValue + ConvertRecursively(binaryDigits, currentIteration);
        }
    }
}
