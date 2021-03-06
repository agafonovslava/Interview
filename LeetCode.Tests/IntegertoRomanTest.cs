using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class IntegertoRomanTest
    {
        [Theory]
        [InlineData(34, "XXXIV")]
        [InlineData(2, "II")]
        [InlineData(17, "XVII")]
        [InlineData(1777, "MDCCLXXVII")]
        public void TestMethod(int num, string output)
        {
            Assert.Equal(output, Solution012.IntToRoman2(num));
        }
    }
}

