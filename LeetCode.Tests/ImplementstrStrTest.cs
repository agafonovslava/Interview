using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class ImplementstrStrTest
    {
        [Theory]
        [InlineData("5556662321321", "12", -1)]
        [InlineData("5556662321321", "13", 9)]
        [InlineData("5556662321321", "5", 0)]
        public void TestMethod(string haystack, string needle, int output)
        {
            Assert.Equal(output, Solution028.StrStr(haystack, needle));
        }
    }
}

