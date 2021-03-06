using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class ThreeSumTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[] nums, IList<IList<int>> output)
        {

            Assert.Equal(output, Solution015.ThreeSum(nums));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[] nums = new[] { -1, 0, 1, 2, -1, -4 };
                IList<IList<int>> output = new List<IList<int>>() {
                    new List<int> { -1, -1, 2 },
                    new List<int> { -1, 0, 1 },
                };
                driverData.Add(new object[] { nums, output });

                return driverData;
            }
        }

    }
}

