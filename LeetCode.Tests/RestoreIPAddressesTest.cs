using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class RestoreIPAddressesTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(string s, IList<string> output)
        {
            Assert.Equal(output, Solution093.RestoreIpAddresses(s));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();

                var s = "25525511135";
                var output = new List<string> { "255.255.11.135", "255.255.111.35" };


                driverData.Add(new object[] { s, output });

                return driverData;
            }
        }
    }
}

