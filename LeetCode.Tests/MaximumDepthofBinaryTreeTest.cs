using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class MaximumDepthofBinaryTreeTest
    {
        [Theory]
        [InlineData(null, 0)]
        [MemberData(nameof(InlineData))]
        public void TestMethod(TreeNode root, int output)
        {
            Assert.Equal(output, Solution104.MaxDepth(root));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                return driverData;
            }
        }
    }
}

