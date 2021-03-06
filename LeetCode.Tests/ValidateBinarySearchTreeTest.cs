using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class ValidateBinarySearchTreeTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(TreeNode root, bool output)
        {
            Assert.Equal(output, Solution098.IsValidBST(root));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();

                var root = new TreeNode(2);
                root.Left = new TreeNode(1);
                root.Right = new TreeNode(3);
                var output = true;
                driverData.Add(new object[] { root, output });
                root = new TreeNode(1);
                root.Left = new TreeNode(2);
                root.Right = new TreeNode(3);
                output = false;

                driverData.Add(new object[] { root, output });

                return driverData;
            }
        }
    }
}

