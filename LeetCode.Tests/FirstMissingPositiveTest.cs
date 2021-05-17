using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class FirstMissingPositiveTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 5, 6, 7 }, 3)]
        public void TestMethod(int[] nums, int output)
        {
            Assert.Equal(output, Solution041.FirstMissingPositive(nums));
        }
    }
}

