using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class BinaryTreeInorderTraversalTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(TreeNode root, IList<int> output)
        {
            Assert.Equal(output, Solution094.InorderTraversal(root));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                TreeNode root = new TreeNode(1);
                root.Right = new TreeNode(2);
                root.Right.Left = new TreeNode(3);

                var output = new List<int> { 1, 3, 2 };
                driverData.Add(new object[] { root, output });

                return driverData;
            }
        }
    }
}

