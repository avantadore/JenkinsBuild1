using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
