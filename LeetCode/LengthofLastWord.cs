// #58 : https://leetcode.com/problems/length-of-last-word/ 
/**********************************************************************************
* Given a string s consists of upper/lower-case alphabets and empty space characters ' ', 
* return the length of last word in the string.
* If the last word does not exist, return 0.
* Note: A word is defined as a character sequence consists of non-space characters only.
* For example, 
* Given s = "Hello World",
* return 5.
Example 1:
Input: s = "Hello World"
Output: 5
Example 2:
Input: s = " "
Output: 0
Constraints:
1 <= s.length <= 10^4
s consists of only English letters and spaces ' '.
**********************************************************************************/

namespace Algorithms
{
    public class Solution058
    {
        public static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            var words = s.Trim().Split(' ');
            var lastWordIndex = words.Length - 1;
            return words[lastWordIndex].Length;
        }
    }
}

