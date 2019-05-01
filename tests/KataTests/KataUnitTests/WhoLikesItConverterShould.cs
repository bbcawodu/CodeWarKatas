using Katas.Models;
using NUnit.Framework;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class WhoLikesItConverterShould
    {
        [Test, Description("It should return correct text")]
        public void TestConvert()
        {
            Assert.AreEqual("no one likes this", WhoLikesItConverter.Convert(new string[0]));
            Assert.AreEqual("Peter likes this", WhoLikesItConverter.Convert(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", WhoLikesItConverter.Convert(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", WhoLikesItConverter.Convert(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", WhoLikesItConverter.Convert(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
