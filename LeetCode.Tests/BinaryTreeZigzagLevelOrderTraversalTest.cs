using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class BinaryTreeZigzagLevelOrderTraversalTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(TreeNode root, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution103.ZigzagLevelOrder(root));
        }


        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                TreeNode root = new TreeNode(3);
                root.Left = new TreeNode(9);
                root.Right = new TreeNode(20);
                root.Right.Left = new TreeNode(15);
                root.Right.Right = new TreeNode(7);

                var output = new List<IList<int>>();
                output.Add(new List<int> { 3 });
                output.Add(new List<int> { 20, 9 });
                output.Add(new List<int> { 15, 7 });
                driverData.Add(new object[] { root, output });

                return driverData;
            }
        }
    }
}

