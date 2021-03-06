using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class SameTreeTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(TreeNode p, TreeNode q, bool output)
        {
            Assert.Equal(output, Solution100.IsSameTree(p, q));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                TreeNode p = new TreeNode(2);
                p.Left = new TreeNode(2);
                p.Right = new TreeNode(2);
                p.Left.Left = new TreeNode(3);
                p.Left.Right = new TreeNode(4);

                TreeNode q = new TreeNode(2);
                q.Left = new TreeNode(2);
                q.Right = new TreeNode(2);
                q.Left.Left = new TreeNode(3);
                q.Left.Right = new TreeNode(4);
                var output = true;
                driverData.Add(new object[] { p, q, output });

                return driverData;
            }
        }
    }
}

