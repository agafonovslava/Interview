using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class MergeTwoSortedListsTest
    {
        [Theory]
        [MemberData(nameof(InputData_Property))]
        public void TestMethod(ListNode<int> l1, ListNode<int> l2, List<int> output)
        {
            Assert.Equal(output, Solution021.MergeTwoLists2(l1, l2).ToList());
        }
        public static IEnumerable<object[]> InputData_Property
        {
            get
            {
                var l1 = new List<int> { 2, 3, 4 }.ToListNode();
                var l2 = new List<int> { 5, 6, 7 }.ToListNode();
                var result = new List<int> { 2, 3, 4, 5, 6, 7 };
                var driverData = new List<object[]>();
                driverData.Add(new object[] { l1, l2, result });
                l1 = new List<int> { 6, 6, 7 }.ToListNode();
                l2 = new List<int> { 5, 6, 7 }.ToListNode();
                result = new List<int> { 5, 6, 6, 6, 7, 7 };
                driverData.Add(new object[] { l1, l2, result });
                return driverData;
            }
        }
    }
}

