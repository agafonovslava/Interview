using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class RotateListTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(ListNode<int> head, int k, ListNode<int> output)
        {
            var result = Solution061.RotateRight(head, k);
            while (output.Next != null)
            {
                Assert.Equal(output.Val, result.Val);

                output = output.Next;
                result = result.Next;
            }
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var head = new List<int> { 1, 2, 3, 4, 5 }.ToListNode();
                var k = 2;
                var output = new List<int> { 4, 5, 1, 2, 3 }.ToListNode();
                driverData.Add(new object[] { head, k, output });
                return driverData;
            }
        }
    }
}

