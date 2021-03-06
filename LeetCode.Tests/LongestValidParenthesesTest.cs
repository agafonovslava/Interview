using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class LongestValidParenthesesTest
    {
        [Theory]
        [InlineData("(()", 2)]
        [InlineData("(())()", 6)]
        [InlineData("((()()(())))()()()()(()()()()()()", 20)]
        [InlineData("(())())()()()))))))))))))()(((((((", 6)]
        [InlineData("(((()()()()))))))))))))()(((((((", 14)]
        public void TestMethod(string s, int output)
        {
            Assert.Equal(output, Solution032.LongestValidParentheses(s));
        }
    }
}

