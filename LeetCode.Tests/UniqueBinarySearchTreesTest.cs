using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class UniqueBinarySearchTreesTest
    {
        [Theory]
        [InlineData(0, 1)]
        public void TestMethod(int n, int output)
        {
            Assert.Equal(output, Solution096.NumTrees(n));
        }
    }
}

