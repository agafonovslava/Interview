using Xunit;
namespace AlgorithmsTest
{
    public class RotationalCipherTest
    {
        [Theory]
        [InlineData("Zebra-493?", 3, "Cheud-726?")]
        [InlineData("abcdefghijklmNOPQRSTUVWXYZ0123456789", 39, "nopqrstuvwxyzABCDEFGHIJKLM9012345678")]
        public void Test_Convert(string input, int rotationFactor, string output)
        {
            Assert.Equal(output, SolutionFacebook.rotationalCipher(input, rotationFactor));
        }
    }
}