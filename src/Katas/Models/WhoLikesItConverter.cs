namespace Katas.Models
{
    public class WhoLikesItConverter
    {
        private const string DisplaySuffixSingular = "likes this";
        private const string DisplaySuffixPlural = "like this";
        private const string DisplayForNoOne = "no one";
        private static string displayText;
        private static string displayPrefix = "";

        public static string Convert(string[] names)
        {
            BuildDisplayPrefix(names);
            BuildDisplayText(names);
            return displayText;
        }

        private static void BuildDisplayPrefix(string[] names)
        {
            switch (names.Length)
            {
                case 0:
                    displayPrefix = DisplayForNoOne;
                    break;
                case 1:
                    displayPrefix = $@"{names[0]}";
                    break;
                case 2:
                    displayPrefix = $@"{names[0]} and {names[1]}";
                    break;
                case 3:
                    displayPrefix = $@"{names[0]}, {names[1]} and {names[2]}";
                    break;
                default:
                    displayPrefix = $@"{names[0]}, {names[1]} and {names.Length - 2} others";
                    break;
            }
        }

        private static void BuildDisplayText(string[] names)
        {
            var displaySuffix = names.Length > 1 ? DisplaySuffixPlural : DisplaySuffixSingular;
            displayText = $@"{displayPrefix} {displaySuffix}";
        }
    }
}
