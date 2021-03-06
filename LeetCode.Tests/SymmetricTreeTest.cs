using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class SymmetricTreeTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(TreeNode root, bool output)
        {
            Assert.Equal(output, Solution101.IsSymmetric(root));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                TreeNode root = new TreeNode(2);
                root.Left = new TreeNode(2);
                root.Right = new TreeNode(2);
                root.Left.Left = new TreeNode(3);
                root.Left.Right = new TreeNode(4);
                root.Right.Left = new TreeNode(4);
                root.Right.Right = new TreeNode(3);
                var output = true;
                driverData.Add(new object[] { root, output });

                return driverData;
            }
        }
    }
}

