using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class ClimbingStairsTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(5, 8)]
        public void TestMethod(int n, int output)
        {
            Assert.Equal(output, Solution070.ClimbStairs(n));
        }
    }
}

