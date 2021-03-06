using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveDuplicatesfromSortedArrayTest
    {
        [Theory]
        [InlineData(new[] { 2, 2, 3 }, 2)]
        [InlineData(new[] { 1, 2, 2, 3, 3, 4, 4 }, 4)]
        public void TestMethod(int[] nums, int output)
        {
            Assert.Equal(output, Solution026.RemoveDuplicates(nums));
        }
    }
}

