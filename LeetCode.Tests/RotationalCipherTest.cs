using System.Collections.Generic;
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

        [Theory]
        [MemberData(nameof(InlineData))]
        public void Test_ContinguousSubarrays(int[] input, int[] output)
        {
            Assert.Equal(output, SolutionFacebook.countSubarrays(input));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var data = new List<object[]>();

                var input = new[] { 1 };
                var output = new[] { 1 };
                data.Add(new object[] { input, output });

                var input2 = new[] { 3, 4, 1, 6, 2 };
                var output2 = new[] { 1, 3, 1, 5, 1 };
                data.Add(new object[] { input2, output2 });

                return data;
            }
        }
    }
}