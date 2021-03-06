using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class RegularExpressionMatchingTest
    {
        [Theory]
        [InlineData("aaa", "aa", false)]
        [InlineData("aab", "c*a*b", true)]
        [InlineData("ab", ".*", true)]
        public void TestMethod(string s, string p, bool output)
        {
            Assert.Equal(output, Solution010.IsMatchWithDP(s, p));
        }
        [Theory]
        [InlineData("aaa", "aa", false)]
        [InlineData("aab", "c*a*b", true)]
        [InlineData("ab", ".*", true)]
        public void TestMethod2(string s, string p, bool output)
        {
            Assert.Equal(output, Solution010.IsMatch(s, p));
        }
    }
}

