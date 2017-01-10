using System.Linq;

namespace Common
{
    public class StringAnalyzer
    {
        public bool IsStringFooBar(string input)
        {
            return input.ToUpper().Contains("FOOBAR");
        }

        public bool IsPalindrome(string input)
        {
            return input.SequenceEqual(input.Reverse());
        }
    }
}
