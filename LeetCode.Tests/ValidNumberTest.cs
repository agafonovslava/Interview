using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class ValidNumberTest
    {
        [Theory]
        [InlineData("0", true)]
        [InlineData(" 0.1 ", true)]
        [InlineData("abc", false)]
        [InlineData("1 a", false)]
        [InlineData("2e10", true)]
        public void TestMethod(string s, bool output)
        {
            Assert.Equal(output, Solution065.IsNumber(s));
        }
    }
}

