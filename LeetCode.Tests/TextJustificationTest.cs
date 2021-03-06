using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class TextJustificationTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(string[] words, int maxWidth, IList<string> output)
        {
            Assert.Equal(output, Solution068.FullJustify(words, maxWidth));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                var words = new[] { "This", "is", "an", "example", "of", "text", "justification." };
                var maxWidth = 16;

                var output = new List<string>
                {
                    "This    is    an",
                    "example  of text",
                    "justification.  "
                };

                driverData.Add(new object[] { words, maxWidth, output });

                return driverData;
            }
        }
    }
}

