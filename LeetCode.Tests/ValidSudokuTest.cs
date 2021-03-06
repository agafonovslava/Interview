using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class ValidSudokuTest
    {
        [Theory]
        [InlineData(new string[] { ".87654321", "2........", "3........", "4........", "5........", "6........", "7........", "8........", "9........" }, true)]
        public void TestMethod(string[] strs, bool output)
        {
            char[,] board = new char[9, 9];
            for (var i = 0; i < strs.Length; i++)
            {
                for (var j = 0; j < strs[i].Length; j++)
                {
                    board[i, j] = strs[i][j];
                }
            }
            Assert.Equal(output, Solution036.IsValidSudoku2(board));
        }
    }
}

