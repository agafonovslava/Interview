using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class DivideTwoIntegersTest
    {
        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(1, 2, 0)]
        [InlineData(8, 3, 2)]
        public void TestMethod(int dividend, int divisor, int output)
        {
            Assert.Equal(output, Solution029.Divide(dividend, divisor));
        }
    }
}

