using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class JumpGameIITest
    {
        [Theory]
        [InlineData(new[] { 2, 3, 1, 1, 4 }, 2)]
        [InlineData(new[] { 3, 2, 1, 0, 4 }, 0)]
        public void TestMethod(int[] nums, int output)
        {
            Assert.Equal(output, Solution045.Jump(nums));
        }
    }
}

