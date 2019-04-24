using System;
using Katas.Models;
using NUnit.Framework;

namespace KataTests.KataUnitTests
{
    [TestFixture]
    class GetVowelCountShould
    {
        [Test]
        [TestCase("abracadabra", ExpectedResult = 5)]
        [TestCase("qoiuweyhuifbd", ExpectedResult = 6)]
        [TestCase("ooooooo", ExpectedResult = 7)]
        public int TestGetVowelCount(string input)
        {
            return VowelCountGetter.GetVowelCount(input);
        }

        [Test]
        [TestCase("abracadabra", ExpectedResult = 5)]
        [TestCase("qoiuweyhuifbd", ExpectedResult = 6)]
        [TestCase("ooooooo", ExpectedResult = 7)]
        public int TestGetSumOfIndividualVowelCount(string input)
        {
            return VowelCountGetter.GetSumOfIndividualVowelCount(input);
        }

        [Test]
        [TestCase("abracadabra", ExpectedResult = 5)]
        [TestCase("qoiuweyhuifbd", ExpectedResult = 6)]
        [TestCase("ooooooo", ExpectedResult = 7)]
        public int TestGetNumberOfLettersThatAreVowel(string input)
        {
            return VowelCountGetter.GetNumberOfLettersThatAreVowel(input);
        }
    }
}
