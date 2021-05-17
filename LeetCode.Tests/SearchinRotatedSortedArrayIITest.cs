using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class SearchinRotatedSortedArrayIITest
    {
        [Theory]
        [InlineData(new[] { 0 }, 1, false)]
        public void TestMethod(int[] nums, int target, bool output)
        {
            Assert.Equal(output, Solution081.Search(nums, target));
        }
    }
}

