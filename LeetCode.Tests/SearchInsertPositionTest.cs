using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class SearchInsertPositionTest
    {
        [Theory]
        [InlineData(new[] { 1, 3, 5, 6 }, 4, 2)]
        [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
        [InlineData(new[] { 1, 3, 5, 6 }, 0, 0)]
        public void TestMethod(int[] nums, int target, int output)
        {
            Assert.Equal(output, Solution035.SearchInsert(nums, target));
        }
    }
}

