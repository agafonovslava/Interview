using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class LengthofLastWordTest
    {
        [Theory]
        [InlineData("who are you", 3)]
        public void TestMethod(string s, int output)
        {
            Assert.Equal(output, Solution058.LengthOfLastWord(s));
        }
    }
}

