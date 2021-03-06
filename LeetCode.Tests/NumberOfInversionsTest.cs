using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class NumberOfInversionsTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void NumberOfInversions1(int[] nums, int output)
        {
            Assert.Equal(output, NumberOfInversionsHelper.CountInversions(nums));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var inversionsData = new List<object[]>();
                int[] nums = new[] { 2, 3, 3, 1, 9, 5, 6 };
                inversionsData.Add(new object[] { nums, 5 });

                return inversionsData;
            }
        }
    }
}

