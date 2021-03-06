using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class UniquePathsIITest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[,] obstacleGrid, int output)
        {
            Assert.Equal(output, Solution063.UniquePathsWithObstacles(obstacleGrid));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[,] obstacleGrid = new int[,] {
                    { 0,0,0 },
                    { 0,1,0},
                    { 0,0,0 }
                };
                int output = 2;
                driverData.Add(new object[] { obstacleGrid, output });
                obstacleGrid = new int[,] {
                    { 0,0 },
                };
                output = 1;
                driverData.Add(new object[] { obstacleGrid, output });
                return driverData;
            }
        }
    }
}

