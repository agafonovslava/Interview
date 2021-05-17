using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class DecodeWaysTest
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("*", 9)]
        [InlineData("1*", 18)]

        public void TestMethod(string s, int output)
        {
            Assert.Equal(output, Solution091.NumDecodings(s));
        }
    }
}

