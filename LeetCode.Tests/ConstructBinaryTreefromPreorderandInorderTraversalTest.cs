using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class ConstructBinaryTreefromPreorderandInorderTraversalTest
    {
        [Theory]
        [InlineData(null, null, null)]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[] preorder, int[] inorder, TreeNode output)
        {
            Assert.Equal(output, Solution105.BuildTree(preorder, inorder));
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

