using Algorithms;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest
{
    public class ReverseOperationsTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void ReverseOperations_Test(Node n, Node output)
        {
            var actual = ReverseOperations.Reverse(n);
            while(output.next != null)
            {
                Assert.Equal(output.data, actual.data);
                output = output.next;
                actual = actual.next;
            }
            
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var head = new Node(1);
                head.next = new Node(2);
                head.next.next = new Node(8);
                head.next.next.next = new Node(9);
                head.next.next.next.next = new Node(12);
                head.next.next.next.next.next = new Node(16);

                var output = new Node(1);
                output.next = new Node(8);
                output.next.next = new Node(2);
                output.next.next.next = new Node(9);
                output.next.next.next.next = new Node(16);
                output.next.next.next.next.next = new Node(12);
                driverData.Add(new object[] { head, output });

                return driverData;
            }
        }
    }
}