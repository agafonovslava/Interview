using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveDuplicatesfromSortedArrayIITest
    {
        [Theory]
        [InlineData(new[] { 1, 2 }, 2)]
        [InlineData(new[] { 1, 1, 1, 2, 2, 3 }, 5)]
        public void TestMethod(int[] nums, int output)
        {
            Assert.Equal(output, Solution080.RemoveDuplicates(nums));
        }
    }
}

