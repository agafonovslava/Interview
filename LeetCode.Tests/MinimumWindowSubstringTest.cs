using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class MinimumWindowSubstringTest
    {
        [Theory]
        [InlineData("", "")]
        public void TestMethod(string s, string output)
        {
            Assert.Equal(output, Solution076.MinWindow(s, s));
        }
    }
}

