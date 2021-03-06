using Algorithms;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest
{
    public class MaximalRectangleTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(char[,] matrix, int output)
        {
            Assert.Equal(output, Solution085.MaximalRectangle(matrix));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var matrix = new[,]
                {
                    { '1','0','1','0','0' },
                    { '1','0','1','1','1'  },
                    { '1','1','1','1','1'  },
                    { '1','0','0','1','0'  }
                };
                var output = 6;

                driverData.Add(new object[] { matrix, output });

                return driverData;
            }
        }
    }
}

