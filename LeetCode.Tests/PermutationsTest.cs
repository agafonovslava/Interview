using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class PermutationsTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[] nums, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution046.Permute(nums));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[] nums = new[] { 1, 2, 3 };
                IList<IList<int>> output = new List<IList<int>>() {
                    new List<int> { 1,2,3 },
                    new List<int> { 1,3,2 },
                    new List<int> { 2,1,3 },
                    new List<int> { 2,3,1 },
                    new List<int> { 3,1,2 },
                    new List<int> { 3,2,1 }
                };
                driverData.Add(new object[] { nums, output });

                return driverData;
            }
        }
    }
}

