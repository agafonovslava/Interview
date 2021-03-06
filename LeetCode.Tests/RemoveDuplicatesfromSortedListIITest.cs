using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveDuplicatesfromSortedListIITest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(ListNode<int> head, ListNode<int> output)
        {
            var result = Solution082.DeleteDuplicates(head);
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
                head.Next = new ListNode<int>(2);
                head.Next.Next = new ListNode<int>(3);
                head.Next.Next.Next = new ListNode<int>(3);
                head.Next.Next.Next.Next = new ListNode<int>(4);
                head.Next.Next.Next.Next.Next = new ListNode<int>(4);
                head.Next.Next.Next.Next.Next.Next = new ListNode<int>(5);
                var output = new ListNode<int>(1);
                output.Next = new ListNode<int>(2);
                output.Next.Next = new ListNode<int>(5);
                driverData.Add(new object[] { head, output });

                return driverData;
            }
        }
    }
}

