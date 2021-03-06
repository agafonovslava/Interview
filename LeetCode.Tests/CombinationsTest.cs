using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class CombinationsTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int n, int k, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution077.Combine(n, k));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var n = 4;
                var k = 2;

                var output = new List<IList<int>>();
                output.Add(new List<int> { 1, 2 });
                output.Add(new List<int> { 1, 3 });
                output.Add(new List<int> { 1, 4 });
                output.Add(new List<int> { 2, 3 });
                output.Add(new List<int> { 2, 4 });
                output.Add(new List<int> { 3, 4 });

                driverData.Add(new object[] { n, k, output });


                return driverData;
            }
        }
    }
}

