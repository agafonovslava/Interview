using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class ScrambleStringTest
    {
        [Theory]
        [InlineData("", "", true)]
        [InlineData("rgtae", "great", true)]
        public void TestMethod(string s1, string s2, bool output)
        {
            Assert.Equal(output, Solution087.IsScramble(s1, s2));
        }
    }
}

