using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class MultiplyStringsTest
    {
        [Theory]
        [InlineData("2", "5", "10")]
        public void TestMethod(string num1, string num2, string output)
        {
            Assert.Equal(output, Solution043.Multiply(num1, num2));
        }
    }
}

