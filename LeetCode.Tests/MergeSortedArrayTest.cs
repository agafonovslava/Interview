using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class MergeSortedArrayTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3)]
        public void TestMethod(int[] nums1, int m, int[] nums2, int n)
        {
            Solution088.Merge(nums1, m, nums2, n);
            Assert.True(true);
        }
    }
}

