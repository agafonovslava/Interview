using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveElementTest
    {
        [Theory]
        [InlineData(new[] { 2, 2, 3 }, 2, 1)]
        public void TestMethod(int[] nums, int val, int output)
        {
            Assert.Equal(output, Solution027.RemoveElement(nums, val));
        }
    }
}

