using Katas.Models;
using NUnit.Framework;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class WordsMoreThan5LettersSpinnerShould
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", WordsMoreThan5LettersSpinner.Spin("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", WordsMoreThan5LettersSpinner.Spin("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", WordsMoreThan5LettersSpinner.Spin("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", WordsMoreThan5LettersSpinner.Spin("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", WordsMoreThan5LettersSpinner.Spin("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", WordsMoreThan5LettersSpinner.Spin("Just kidding there is still one more"));
        }
    }
}
