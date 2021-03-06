using Algorithms;
using Algorithms.Utils;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class SwapNodesinPairsTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(ListNode<int> head, List<int> output)
        {
            Assert.Equal(output, Solution024.SwapPairs(head).ToList());
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var head = new List<int> { 2, 3, 4, 5 }.ToListNode();
                var output = new List<int> { 3, 2, 5, 4 };
                driverData.Add(new object[] { head, output });

                return driverData;
            }
        }
    }
}

