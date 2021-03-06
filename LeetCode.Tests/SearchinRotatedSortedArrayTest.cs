using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class SearchinRotatedSortedArrayTest
    {
        [Theory]
        [InlineData(new[] { 1 }, 0, -1)]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        public void TestMethod(int[] nums, int target, int output)
        {
            Assert.Equal(output, Solution033.Search(nums, target));
        }
    }
}

