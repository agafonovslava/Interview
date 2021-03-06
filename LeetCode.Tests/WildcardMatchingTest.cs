using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class WildcardMatchingTest
    {
        [Theory]
        [InlineData("aa", "a", false)]
        [InlineData("aa", "aa", true)]
        [InlineData("aa", "*", true)]
        [InlineData("aa", "a*", true)]
        [InlineData("ab", "?*", true)]
        public void TestMethod(string s, string p, bool output)
        {
            Assert.Equal(output, Solution044.IsMatch(s, p));
        }
    }
}

