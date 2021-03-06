using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class NQueensTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int n, IList<IList<string>> output)
        {
            Assert.Equal(output, Solution051.SolveNQueens(n));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int n = 4;
                IList<IList<string>> output = new List<IList<string>>() {
                    new List<string> {".Q..", "...Q","Q...","..Q."},
                    new List<string> {"..Q.","Q...","...Q",".Q.."}
                };
                driverData.Add(new object[] { n, output });

                return driverData;
            }
        }
    }
}

