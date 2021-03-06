// #65 : https://leetcode.com/problems/valid-number/ 
/**********************************************************************************
* Validate if a given string is numeric.
* Some examples:
* "0" => true
* "   0.1  " => true
* "abc" => false
* "1 a" => false
* "2e10" => true
* Note: It is intended for the problem statement to be ambiguous. You should gather all requirements up front before implementing one.
* The signature of the C++ function had been updated. If you still see your function signature accepts a const char * argument, please click the reload button  to reset your code definition.
* Example 1:
Input: s = "0"
Output: true
Example 2:
Input: s = "e"
Output: false
Example 3:
Input: s = "."
Output: false
Example 4:
Input: s = ".1"
Output: true
Constraints:
1 <= s.length <= 20
s consists of only English letters (both uppercase and lowercase), digits (0-9), plus '+', minus '-', or dot '.'.
**********************************************************************************/

namespace Algorithms
{
    public class Solution065
    {
        public static bool IsNumber(string s)
        {
            if (s == null)
                return false;
            s = s.Trim();
            if (s.Length == 0)
                return false;
            bool dotFlag = false;
            bool eFlag = false;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '.':
                        if (dotFlag || eFlag
                        || ((i == 0 || !(s[i - 1] >= '0' && s[i - 1] <= '9'))
                            && (i == s.Length - 1 || !(s[i + 1] >= '0' && s[i + 1] <= '9'))))
                            return false;
                        dotFlag = true;
                        break;
                    case '+':
                    case '-':
                        if ((i > 0 && (s[i - 1] != 'e' && s[i - 1] != 'E'))
                        || (i == s.Length - 1 || !(s[i + 1] >= '0' && s[i + 1] <= '9' || s[i + 1] == '.')))
                            return false;
                        break;
                    case 'e':
                    case 'E':
                        if (eFlag || i == s.Length - 1 || i == 0)
                            return false;
                        eFlag = true;
                        break;
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }
    }
}

