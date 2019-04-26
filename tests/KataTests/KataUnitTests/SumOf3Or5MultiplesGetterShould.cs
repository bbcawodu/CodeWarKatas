using Katas.Models;
using NUnit.Framework;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class SumOf3Or5MultiplesGetterShould
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, SumOf3Or5MultiplesGetter.Get(10));
            Assert.AreEqual(45, SumOf3Or5MultiplesGetter.Get(15));
            Assert.AreEqual(78, SumOf3Or5MultiplesGetter.Get(20));
            Assert.AreEqual(143, SumOf3Or5MultiplesGetter.Get(25));
            Assert.AreEqual(195, SumOf3Or5MultiplesGetter.Get(30));
        }
    }
}
