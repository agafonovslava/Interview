using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class PalindromeNumberTest
    {
        [Theory]
        [InlineData(1000021, false)]
        [InlineData(111, true)]
        [InlineData(1113, false)]
        public void TestMethod(int x, bool output)
        {
            Assert.Equal(output, Solution009.IsPalindromeFast(x));
        }
    }
}