using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class KnuthMorrisPrattTests
    {
        [Theory]
        [InlineData("", "", false)]
        [InlineData("aabcc", "dabca", false)]
        [InlineData("aabcc", "dbbca", false)]
        [InlineData("aefaefaefaedaefaedaefaefa", "aefaedaefaefa", true)]
        [InlineData("123a321b", "123", true)]
        [InlineData("123a321b", "321", true)]
        [InlineData("123a321b", "3a3", true)]
        public void KmpTest(string s1, string s2, bool output)
        {
            Assert.Equal(output, KMP.KnuthMorrisPrattAlgorithm(s1, s2));
        }
    }
}


