using Katas.Models;
using NUnit.Framework;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class WhoLikesItGetterShould
    {
        [Test, Description("It should return correct text")]
        public void TestGet()
        {
            Assert.AreEqual("no one likes this", WhoLikesItGetter.Get(new string[0]));
            Assert.AreEqual("Peter likes this", WhoLikesItGetter.Get(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", WhoLikesItGetter.Get(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", WhoLikesItGetter.Get(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", WhoLikesItGetter.Get(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
