using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class SudokuSolverTest
    {
        [Theory]
        [InlineData(new string[] { "..9748...", "7........", ".2.1.9...", "..7...24.", ".64.1.59.", ".98...3..", "...8.3.2.", "........6", "...2759.." }
        , new string[] { "519748632", "783652419", "426139875", "357986241", "264317598", "198524367", "975863124", "832491756", "641275983" })]
        public void TestMethod(string[] strs, string[] output)
        {
            char[,] board = new char[9, 9];
            for (var i = 0; i < strs.Length; i++)
            {
                for (var j = 0; j < strs[i].Length; j++)
                {
                    board[i, j] = strs[i][j];
                }
            }
            char[,] solver = new char[9, 9];
            for (var i = 0; i < output.Length; i++)
            {
                for (var j = 0; j < output[i].Length; j++)
                {
                    solver[i, j] = output[i][j];
                }
            }
            Assert.Equal(solver, Solution037.SolveSudoku(board));
        }
    }
}

