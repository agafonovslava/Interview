using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveDuplicatesfromSortedListTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(ListNode<int> head, ListNode<int> output)
        {
            var result = Solution083.DeleteDuplicates(head);
            while (output != null)
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
                var head = new ListNode<int>(1);
                head.Next = new ListNode<int>(1);
                head.Next.Next = new ListNode<int>(2);

                var output = new ListNode<int>(1);
                output.Next = new ListNode<int>(2);
                driverData.Add(new object[] { head, output });

                return driverData;
            }
        }
    }
}

