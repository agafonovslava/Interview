using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class PartitionListTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(ListNode<int> head, int x, ListNode<int> output)
        {
            var result = Solution086.Partition(head, x);
            while(output.Next != null)
            {
                Assert.Equal(output.Val, result.Val);

                result = result.Next;
                output = output.Next;
            }
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var head = new ListNode<int>(1);
                head.Next = new ListNode<int>(4);
                head.Next.Next = new ListNode<int>(3);
                head.Next.Next.Next = new ListNode<int>(2);
                head.Next.Next.Next.Next = new ListNode<int>(5);
                head.Next.Next.Next.Next.Next = new ListNode<int>(2);
                var x = 3;
                var output = new ListNode<int>(1);
                output.Next = new ListNode<int>(2);
                output.Next.Next = new ListNode<int>(2);
                output.Next.Next.Next = new ListNode<int>(4);
                output.Next.Next.Next.Next = new ListNode<int>(3);
                output.Next.Next.Next.Next.Next = new ListNode<int>(5);
                driverData.Add(new object[] { head, x, output });

                return driverData;
            }
        }
    }
}

