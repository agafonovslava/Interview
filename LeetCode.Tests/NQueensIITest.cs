using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class NQueensIITest
    {
        [Theory]
        [InlineData(4, 2)]
        public void TestMethod(int n, int output)
        {
            Assert.Equal(output, Solution052.TotalNQueens(n));
        }
    }
}

