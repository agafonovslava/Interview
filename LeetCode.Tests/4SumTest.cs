using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class FourSumTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[] nums, int target, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution018.FourSum(nums, target));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[] nums = new[] { 1, 0, -1, 0, -2, 2 };
                int target = 0;
                IList<IList<int>> output = new List<IList<int>>() {
                    new List<int> { -2, -1, 1, 2},
                    new List<int> {-2,  0, 0, 2},
                    new List<int> {-1,  0, 0, 1},
                };
                driverData.Add(new object[] { nums, target, output });

                return driverData;
            }
        }
    }
}

