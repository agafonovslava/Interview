using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class SpiralMatrixIITest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int n, int[,] output)
        {
            Assert.Equal(output, Solution059.GenerateMatrix(n));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int n = 3;
                int[,] output = new int[,] {
                    { 1, 2, 3 },
                    { 8, 9, 4 },
                    { 7, 6, 5 }
                };

                driverData.Add(new object[] { n, output });

                return driverData;
            }
        }
    }
}

