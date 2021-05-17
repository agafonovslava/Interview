using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class SortColorsTest
    {
        [Theory]
        [InlineData(new[] { 2, 0, 2, 1, 1, 0 })]
        [InlineData(new[] { 2, 0, 1 })]
        public void TestMethod(int[] nums)
        {
            Solution075.SortColors(nums);
        }
    }
}

