using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class UniquePathsTest
    {
        [Theory]
        [InlineData(3, 7, 28)]
        public void TestMethod(int m, int n, int output)
        {
            Assert.Equal(output, Solution062.UniquePaths(m, n));
        }
    }
}

