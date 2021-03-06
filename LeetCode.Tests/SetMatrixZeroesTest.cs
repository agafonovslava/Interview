using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class SetMatrixZeroesTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[,] matrix)
        {
            Solution073.SetZeroes(matrix);
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var matrix = new[,]
                {
                    { 1, 2 },
                    { 3, 4 },
                    { 5, 6 },
                    { 7, 8 }
                };


                driverData.Add(new object[] { matrix });

                return driverData;
            }
        }
    }
}

