using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class SqrtxTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(4, 2)]
        public void TestMethod(int x, int output)
        {
            Assert.Equal(output, Solution069.MySqrt(x));
        }
    }
}

