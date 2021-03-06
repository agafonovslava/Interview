// #17 : https://leetcode.com/problems/letter-combinations-of-a-phone-number/ 

/***************************************************************************************
* Given a digit string, return all possible letter combinations that the number could represent.
* A mapping of digit to letters (just like on the telephone buttons) is given below.
* | 1(o_o)  2(abc) 3(def)  |
* | 4(ghi)  5(jkl) 6(mno)  | 
* | 7(pqrs) 8(tuv) 9(wxyz) |
* | *(+)    0(︺)  ⬆️(#)    |
* ——————————————————————————
* Input:Digit string "23"
* Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
* Note:
* Although the above answer is in lexicographical order, your answer could be in any order you want.
Example 1:
Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Example 2:
Input: digits = ""
Output: []
Example 3:
Input: digits = "2"
Output: ["a","b","c"]
Constraints:
0 <= digits.length <= 4
digits[i] is a digit in the range ['2', '9'].
**********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Solution017
    {
        public static IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }
            Dictionary<char, char[]> dict = new Dictionary<char, char[]>
            {
                {'0',new char[]{}},
                {'1',new char[]{}},
                {'2',new[]{'a','b','c'}},
                {'3',new[]{'d', 'e', 'f'}},
                {'4', new [] { 'g', 'h', 'i' }},
                {'5', new [] { 'j', 'k', 'l' }},
                {'6', new [] { 'm', 'n', 'o' }},
                {'7', new [] { 'p', 'q', 'r', 's' }},
                {'8', new [] { 't', 'u', 'v'}},
                {'9', new [] { 'w', 'x', 'y', 'z' }}
            };
            StringBuilder s = new StringBuilder();
            Helper(result, dict, s, digits, 0);
            return result;
        }

        private static void Helper(List<String> result, Dictionary<char, char[]> dict, StringBuilder s, String digits, int i)
        {
            if (digits.Length == s.Length)
            {
                result.Add(s.ToString());
                return;
            }
            foreach (char c in dict[digits[i]])
            {
                s.Append(c);
                Helper(result, dict, s, digits, i + 1);
                s.Remove(s.Length - 1, 1);
            }
        }
    }
}

