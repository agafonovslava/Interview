using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class CountandSayTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "11")]
        [InlineData(3, "21")]
        [InlineData(5, "111221")]
        [InlineData(6, "312211")]
        public void TestMethod(int n, string output)
        {
            Assert.Equal(output, Solution038.CountAndSay(n));
        }
    }
}

