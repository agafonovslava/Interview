using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class MaximumSubarrayTest
    {
        [Theory]
        [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        public void TestMethod(int[] nums, int output)
        {
            Assert.Equal(output, Solution053.MaxSubArray(nums));
        }
    }
}

