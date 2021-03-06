using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class LongestCommonPrefixTest
    {
        [Theory]
        [InlineData(new[] { "1234", "123", "12" }, "12")]
        [InlineData(new[] { "1234", "123", "12345" }, "123")]
        [InlineData(new[] { "1234", "123", "11", "22" }, "")]
        public void TestMethod(string[] arr, string output)
        {
            Assert.Equal(output, Solution014.LongestCommonPrefix(arr));
        }
    }
}

