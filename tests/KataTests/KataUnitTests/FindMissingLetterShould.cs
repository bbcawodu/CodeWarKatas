using NUnit.Framework;
using Katas.Models;

namespace KataTests.KataUnitTests
{
    class FindMissingLetterShould
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual('e', MissingLetterFinder.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Assert.AreEqual('P', MissingLetterFinder.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }
    }
}
