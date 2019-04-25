using Katas.Models;
using NUnit.Framework;
using System;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class BinaryArrayToNumberConverterShould
    {
        int[] test1 = new int[] { 0, 0, 0, 0 };
        int[] test2 = new int[] { 1, 1, 1, 1 };
        int[] test3 = new int[] { 0, 1, 1, 0 };
        int[] test4 = new int[] { 0, 1, 0, 1 };
        [Test]
        public void BasicTesting()
        {
            Assert.AreEqual(0, BinaryArrayToNumberConverter.Convert(test1));
            Assert.AreEqual(15, BinaryArrayToNumberConverter.Convert(test2));
            Assert.AreEqual(6, BinaryArrayToNumberConverter.Convert(test3));
            Assert.AreEqual(5, BinaryArrayToNumberConverter.Convert(test4));
        }
    }
}
