using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class GenerateParenthesesTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(int n, IList<string> output)
        {
            Assert.Equal(output, Solution022.GenerateParenthesis(n));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int n = 3;
                IList<string> output = new List<string>() {
                    "((()))",
                    "(()())",
                    "(())()",
                    "()(())",
                    "()()()"
                };
                driverData.Add(new object[] { n, output });

                return driverData;
            }
        }
    }
}

