using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class SubsetsIITest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[] nums, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution090.SubsetsWithDup(nums));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var nums = new[] { 1, 2, 2 };

                var output = new List<IList<int>>();
                output.Add(new List<int> { 1, 2, 2 });
                output.Add(new List<int> { 1, 2 });
                output.Add(new List<int> { 1, 2 });
                output.Add(new List<int> { 1 });
                output.Add(new List<int> { 2, 2 });
                output.Add(new List<int> { 2 });
                output.Add(new List<int> { 2 });
                output.Add(new List<int>());
                driverData.Add(new object[] { nums, output });

                return driverData;
            }
        }
    }
}

