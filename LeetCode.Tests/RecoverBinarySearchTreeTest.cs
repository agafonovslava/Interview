using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class RecoverBinarySearchTreeTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethodMorris(TreeNode root)
        {
            Solution099.RecoverTree(root);
        }

        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethodSimple(TreeNode root)
        {
            Solution099.RecoverTreeSimple(root);
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


                driverData.Add(new object[] { root });

                return driverData;
            }
        }
    }
}

