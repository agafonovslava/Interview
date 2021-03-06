using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class NextPermutationTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 3, 2 })]
        [InlineData(new[] { 1, 3, 3 }, new[] { 3, 1, 3 })]
        [InlineData(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        public void TestMethod(int[] nums, int[] output)
        {
            Assert.Equal(output, Solution031.NextPermutation(nums));
        }
    }
}

