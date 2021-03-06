using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class ReverseNodesinkGroupTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(ListNode<int> head, int k, List<int> output)
        {
            Assert.Equal(output, Solution025.ReverseKGroup(head, k).ToList());
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var head = new List<int> { 2, 3, 4, 5 }.ToListNode();
                var k = 3;
                var output = new List<int> { 4, 3, 2, 5 };
                driverData.Add(new object[] { head, k, output });
                head = new List<int> { 2, 3, 4, 5 }.ToListNode();
                k = 2;
                output = new List<int> { 3, 2, 5, 4 };
                driverData.Add(new object[] { head, k, output });
                return driverData;
            }
        }
    }
}

