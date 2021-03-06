using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class UniqueBinarySearchTreesIITest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int n, IList<TreeNode> output)
        {
            IList<TreeNode> result = Solution095.GenerateTrees(n);
            for (int i = 0; i < output.Count; i++)
            {
                Assert.Equal(output[i].Val, result[i].Val);
            }
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var nums = 3;

                var output = new List<TreeNode>();
                var root = new TreeNode(1);
                root.Right = new TreeNode(3);
                root.Right.Left = new TreeNode(2);
                output.Add(root);
                driverData.Add(new object[] { nums, output });

                return driverData;
            }
        }
    }
}

