using Katas.Models;
using NUnit.Framework;
using System;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class BinaryArrayToNumberConverterShould
    {
        private readonly int[] test1 = { 0, 0, 0, 0 };
        private readonly int[] test2 = { 1, 1, 1, 1 };
        private readonly int[] test3 = { 0, 1, 1, 0 };
        private readonly int[] test4 = { 0, 1, 0, 1 };

        [Test]
        public void TestConvert()
        {
            Assert.AreEqual(0, BinaryArrayToNumberConverter.Convert(test1));
            Assert.AreEqual(15, BinaryArrayToNumberConverter.Convert(test2));
            Assert.AreEqual(6, BinaryArrayToNumberConverter.Convert(test3));
            Assert.AreEqual(5, BinaryArrayToNumberConverter.Convert(test4));
        }
    }
}
