using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class EditDistanceTest
    {
        [Theory]
        [InlineData("", "", 0)]
        [InlineData("12", "123", 1)]
        public void TestMethod(string word1, string word2, int output)
        {
            Assert.Equal(output, Solution072.MinDistance(word1, word2));
        }
    }
}

