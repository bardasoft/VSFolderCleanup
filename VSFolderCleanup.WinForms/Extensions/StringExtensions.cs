using System.Collections.Generic;
using System.Linq;

namespace VSFolderCleanup.Extensions
{
    internal static class StringExtensions
    {
        public static bool EqualsAny(this string input, IEnumerable<string> matchingStrings)
        {
            return (matchingStrings.Any(s => s.Equals(input)));
        }

        public static bool ContainsAny(this string input, params string[] matchingStrings)
        {
            return matchingStrings.Any(s => input.Contains(s));
        }
    }
}
