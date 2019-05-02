using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Models
{
    public class WordsMoreThan5LettersSpinner
    {
        private static List<string> _separatedWords;

        public static string Spin(string words)
        {
            SeparateWords(words);
            var spunSeparatedWords = SpinSeparatedWords();
            return string.Join(" ", spunSeparatedWords);
        }

        private static void SeparateWords(string words)
        {
            _separatedWords = words.Split(
                new string[] {" "},
                StringSplitOptions.RemoveEmptyEntries
            ).ToList();
        }

        private static List<string> SpinSeparatedWords()
        {
            var spunWords = _separatedWords.Select( word =>
                (word.Length >= 5) ? string.Join("", word.Reverse()) : word
            ).ToList();

            return spunWords;
        }
    }
}
