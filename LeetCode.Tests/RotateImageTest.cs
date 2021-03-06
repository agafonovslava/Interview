using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class RotateImageTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int[,] matrix, int[,] output)
        {
            Assert.Equal(output, Solution048.Rotate(matrix));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var matrix = new[,]
                {
                    { 1,2,3 },
                    { 4,5,6 },
                    { 7,8,9 }
                };
                var output = new[,]
                {
                    { 7,4,1 },
                    { 8,5,2 },
                    { 9,6,3 }
                };

                driverData.Add(new object[] { matrix, output });

                return driverData;
            }
        }
    }
}

