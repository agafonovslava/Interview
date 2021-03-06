using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class SpiralMatrixTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[,] matrix, IList<int> output)
        {
            Assert.Equal(output, Solution054.SpiralOrder(matrix));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[,] matrix = new int[,] {
                    { 1, 2 },
                    { 3, 4 },
                    { 5, 6 },
                    { 7, 8 }
                };
                IList<int> output = new List<int>() {
                    1,2,4,6,8,7,5,3
                };
                driverData.Add(new object[] { matrix, output });

                return driverData;
            }
        }
    }
}

