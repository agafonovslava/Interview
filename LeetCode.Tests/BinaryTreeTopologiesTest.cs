using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class BinaryTreeTopologiesTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        [InlineData(5, 42)]
        public void TreeTopologiesTest(int n, int output)
        {
            Assert.Equal(output, BinaryTreeTopologies.NumberOfBinaryTreeTopologies(n));
        }
    }
}

