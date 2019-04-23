using Katas.Models;
using NUnit.Framework;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class CreatePhoneNumberShould
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        public static string TestCreatePhoneNumber(int[] phoneNumberArray)
        {
            return PhoneNumberCreator.CreatePhoneNumber(phoneNumberArray);
        }
    }
}
