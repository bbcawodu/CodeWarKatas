using Katas.Models;
using NUnit.Framework;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class DigitalRootGetterShould
    {
        private DigitalRootGetter digitalRootGetter;

        [SetUp]
        public void SetUp()
        {
            digitalRootGetter = new DigitalRootGetter();
        }

        [TearDown]
        public void TearDown()
        {
            digitalRootGetter = null;
        }

        [Test]
        public void TestGet()
        {
            Assert.AreEqual(7, digitalRootGetter.Get(16));
            Assert.AreEqual(6, digitalRootGetter.Get(456));
        }
    }
}
