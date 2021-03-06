using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class MergeSortTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 0, 8, -1 }, new[] { -1, 0, 1, 2, 3, 8 })]
        public void MergeSortMethod(int[] nums1, int[] nums2)
        {
            var actual = MergeSortAlgoExpertHelper.MergeSort(nums1);
            Assert.Equal(nums2, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 0, 8, -1 }, new[] { -1, 0, 1, 2, 3, 8 })]
        public void MergeSort2Method(int[] nums1, int[] nums2)
        {
            var actual = MergeSortAlgoExpertHelper.MergeSort2(nums1);
            Assert.Equal(nums2, actual);
        }
    }
}

