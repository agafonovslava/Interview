using Algorithms;
using System.Collections.Generic;
using Xunit;
namespace AlgorithmsTest
{
    public class WordSearchTest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(char[,] board, string word, bool output)
        {
            Assert.Equal(output, Solution079.Exist(board, word));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                char[,] board = new char[,] {
                    { 'A','B','C','E' },
                    { 'S','F','C','S'},
                    { 'A','D','E','E' }
                };
                var word = "ABCCED";
                bool output = true;
                driverData.Add(new object[] { board, word, output });
                word = "SEE";
                output = true;
                driverData.Add(new object[] { board, word, output });
                word = "ABCB";
                output = false;
                driverData.Add(new object[] { board, word, output });
                return driverData;
            }
        }
    }
}

