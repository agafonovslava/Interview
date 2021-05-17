using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class LargestRectangleinHistogramTest
    {
        [Theory]
        [InlineData(new[] { 1, 2 }, 2)]
        public void TestMethod(int[] heights, int output)
        {
            Assert.Equal(output, Solution084.LargestRectangleArea(heights));
        }
    }
}

