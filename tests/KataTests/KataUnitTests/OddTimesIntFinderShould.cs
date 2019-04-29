using Katas.Models;
using NUnit.Framework;
using System;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class OddTimesIntFinderShould
    {
        [Test]
        public void TestGet()
        {
            Assert.AreEqual(5, OddTimesIntFinder.Get(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}
