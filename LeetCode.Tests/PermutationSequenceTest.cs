using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class PermutationSequenceTest
    {
        [Theory]
        [InlineData(3, 2, "132")]
        public void TestMethod(int n, int k, string output)
        {
            Assert.Equal(output, Solution060.GetPermutation(n, k));
        }
    }
}

