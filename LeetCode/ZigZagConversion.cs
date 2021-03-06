// #6 : https://leetcode.com/problems/zigzag-conversion/ 
/***************************************************************************************
* The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility) 
* P   A   H   N
* A P L S I I G
* Y   I   R
* And then read line by line: "PAHNAPLSIIGYIR"
* Write the code that will take a string and make this conversion given a number of rows: 
* string convert(string text, int nRows);convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR". 
Example 1:
Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:
Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:
P     I    N
A   L S  I G
Y A   H R
P     I
Example 3:
Input: s = "A", numRows = 1
Output: "A"
**********************************************************************************/
using System.Text;

namespace Algorithms
{
    public class Solution006
    {
        public static string Convert(string s, int numRows)
        {
            if (s.Length <= numRows || numRows <= 1)
            {
                return s;
            }
            StringBuilder result = new StringBuilder();
            var size = 2 * numRows - 2;
            for (var i = 0; i < numRows; i++)
            {
                for (var j = i; j < s.Length; j += size)
                {
                    result.Append(s[j]);
                    if (i > 0 && i < numRows - 1)
                    {
                        var z = j + size - 2 * i;
                        if (z < s.Length)
                        {
                            result.Append(s[z]);
                        }

                    }
                }
            }
            return result.ToString();
        }
    }
}

