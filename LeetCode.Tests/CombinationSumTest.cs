using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class CombinationSumTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[] candidates, int target, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution039.CombinationSum(candidates, target));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[] nums = new[] { 1, 2, 3 };
                int target = 6;
                IList<IList<int>> output = new List<IList<int>>() {
                    new List<int> { 1,1,1,1,1,1 },
                    new List<int> { 1,1,1,1,2 },
                    new List<int> { 1,1,1,3 },
                    new List<int> { 1,1,2,2 },
                    new List<int> { 1,2,3 },
                    new List<int> { 2,2,2 },
                    new List<int> { 3,3 }
                };
                driverData.Add(new object[] { nums, target, output });

                return driverData;
            }
        }
    }
}

