using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class AddBinaryTest
    {
        [Theory]
        [InlineData("1", "11", "100")]
        public void TestMethod(string a, string b, string output)
        {
            Assert.Equal(output, Solution067.AddBinary(a, b));
        }
    }
}

