using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class ThreeSumClosestTest
    {
        [Theory]
        [InlineData(new[] { 0, 0, 0 }, 1, 0)]
        [InlineData(new[] { -1, 2, 1, -4 }, 1, 2)]
        [InlineData(new[] { -6, 0, 3, 4, 1, -2 }, 3, 3)]
        public void TestMethod(int[] nums, int targert, int output)
        {
            Assert.Equal(output, Solution016.ThreeSumClosest(nums, targert));
        }
    }
}

