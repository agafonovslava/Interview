// #13 : https://leetcode.com/problems/roman-to-integer/ 
/***************************************************************************************
* Given a roman numeral, convert it to an integer.
* Input is guaranteed to be within the range from 1 to 3999.
Example 1:
Input: s = "III"
Output: 3
Example 2:
Input: s = "IV"
Output: 4
Example 3:
Input: s = "IX"
Output: 9
Example 4:
Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 5:
Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
Constraints:
1 <= s.length <= 15
s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
It is guaranteed that s is a valid roman numeral in the range [1, 3999].
**********************************************************************************/
using System.Collections.Generic;

namespace Algorithms
{
    public class Solution013
    {
        public static int RomanToInt(string s)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>{
                 {'M',1000},
                 {'D',500},
                 {'C',100},
                 {'L',50},
                 {'X',10},
                 {'V',5},
                 {'I',1}
            };
            int i = s.Length - 1;
            int ret = dict[s[i--]];
            while (i >= 0)
            {
                if (dict[s[i + 1]] > dict[s[i]])
                    ret -= dict[s[i--]];
                else
                    ret += dict[s[i--]];
            }
            return ret;

        }
    }
}

