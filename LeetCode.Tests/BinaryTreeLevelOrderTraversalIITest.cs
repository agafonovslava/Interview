using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class BinaryTreeLevelOrderTraversalIITest
    {
        [Theory]
        [InlineData(null, null)]
        public void TestMethod(TreeNode root, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution107.LevelOrderBottom(root));
        }
    }
}