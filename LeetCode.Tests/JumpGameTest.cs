using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class JumpGameTest
    {
        [Theory]
        [InlineData(new[] { 2, 3, 1, 1, 4 }, true)]
        [InlineData(new[] { 3, 2, 1, 0, 4 }, false)]
        public void TestMethod(int[] nums, bool output)
        {
            Assert.Equal(output, Solution055.CanJump(nums));
        }
    }
}

