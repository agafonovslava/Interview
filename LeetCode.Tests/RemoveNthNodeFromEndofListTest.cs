using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveNthNodeFromEndofListTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(ListNode<int> head, int n, List<int> output)
        {
            Assert.Equal(output, Solution019.RemoveNthFromEnd(head, n).ToList());
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var l1 = new List<int> { 1, 2, 3, 4, 5 }.ToListNode();
                var n = 2;
                var result = new List<int> { 1, 2, 3, 5 };
                var driverData = new List<object[]>();
                driverData.Add(new object[] { l1, n, result });
                l1 = new List<int> { 6, 1, 7, 5, 5, 4 }.ToListNode();
                n = 3;
                result = new List<int> { 6, 1, 7, 5, 4 };
                driverData.Add(new object[] { l1, n, result });
                return driverData;
            }
        }
    }
}

