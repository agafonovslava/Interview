using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class MergekSortedListsTest
    {
        [Theory]
        [MemberData(nameof(InputData_Property))]
        public void TestMethod(ListNode<int>[] nodes, List<int> output)
        {
            Assert.Equal(output, Solution023.MergeKLists(nodes).ToList());
        }
        public static IEnumerable<object[]> InputData_Property
        {
            get
            {
                var l1 = new List<int> { 2, 3, 4 }.ToListNode();
                var l2 = new List<int> { 5, 8, 9 }.ToListNode();
                var l3 = new List<int> { 4, 5, 6 }.ToListNode();
                var nodes = new ListNode<int>[] { l1, l2, l3 };
                var result = new List<int> { 2, 3, 4, 4, 5, 5, 6, 8, 9 };
                var driverData = new List<object[]>();
                driverData.Add(new object[] { nodes, result });
                l1 = new List<int> { 6, 6, 7 }.ToListNode();
                l2 = new List<int> { 5, 6, 7 }.ToListNode();
                l3 = new List<int> { 1, 8, 9 }.ToListNode();
                nodes = new ListNode<int>[] { l1, l2, l3 };
                result = new List<int> { 1, 5, 6, 6, 6, 7, 7, 8, 9 };
                driverData.Add(new object[] { nodes, result });
                return driverData;
            }
        }
    }
}

