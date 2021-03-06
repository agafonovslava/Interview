using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class CombinationSumIITest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[] candidates, int target, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution040.CombinationSum2(candidates, target));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[] candidates = new[] { 10, 1, 2, 7, 6, 1, 5 };
                int target = 8;
                IList<IList<int>> output = new List<IList<int>>() {
                    new List<int> { 1, 1, 6 },
                    new List<int> { 1, 2, 5 },
                    new List<int> { 1, 7 },
                    new List<int> { 2, 6 }
                };
                driverData.Add(new object[] { candidates, target, output });

                return driverData;
            }
        }
    }
}

