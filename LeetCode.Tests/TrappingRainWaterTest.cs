using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class TrappingRainWaterTest
    {
        [Theory]
        [InlineData(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
        public void TestMethod(int[] height, int output)
        {
            Assert.Equal(output, Solution042.Trap(height));
        }
    }
}

