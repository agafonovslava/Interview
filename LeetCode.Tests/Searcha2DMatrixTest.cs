using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class Searcha2DMatrixTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[,] matrix, int target, bool output)
        {
            Assert.Equal(output, Solution074.SearchMatrix(matrix, target));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var matrix = new int[,] { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 50 } };
                var target = 3;
                var output = true;
                driverData.Add(new object[] { matrix, target, output });
                return driverData;
            }
        }
    }
}

