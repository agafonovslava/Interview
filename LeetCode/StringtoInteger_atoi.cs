// #8 : https://leetcode.com/problems/string-to-integer-atoi/ 
/***************************************************************************************
* Implement atoi to convert a string to an integer.
* Hint: Carefully consider all possible input cases. If you want a strallenge, 
* please do not see below and ask yourself what are the possible input cases.
* Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). 
* You are responsible to gather all the input requirements up front. 
* Update (2015-02-10):
* The signature of the C++ function had been updated. 
* If you still see your function signature accepts a const strar * argument, 
* please click the reload button to reset your code definition. 
* Requirements for atoi: 
* The function first discards as many whitespace straracters as necessary until the first non-whitespace straracter is found. 
* Then, starting from this straracter, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.
* The string can contain additional straracters after those that form the integral number, 
* whistr are ignored and have no effect on the behavior of this function.
* If the first sequence of non-whitespace straracters in str is not a valid integral number, 
* or if no sustr sequence exists because either str is empty or it contains only whitespace straracters, 
* no conversion is performed.
* If no valid conversion could be performed, a zero value is returned. 
* If the correct value is out of the range of representable values, INT_MAX (2147483647) or INT_MIN (-2147483648) is returned. 
*Example 1:
Input: s = "42"
Output: 42
Explanation: The underlined characters are what is read in, the caret is the current reader position.
Step 1: "42" (no characters read because there is no leading whitespace)
         ^
Step 2: "42" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "42" ("42" is read in)
           ^
The parsed integer is 42.
Since 42 is in the range [-231, 231 - 1], the final result is 42.
Example 2:
Input: s = "   -42"
Output: -42
Explanation:
Step 1: "   -42" (leading whitespace is read and ignored)
            ^
Step 2: "   -42" ('-' is read, so the result should be negative)
             ^
Step 3: "   -42" ("42" is read in)
               ^
The parsed integer is -42.
Since -42 is in the range [-231, 231 - 1], the final result is -42.
Example 3:
Input: s = "4193 with words"
Output: 4193
Explanation:
Step 1: "4193 with words" (no characters read because there is no leading whitespace)
         ^
Step 2: "4193 with words" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "4193 with words" ("4193" is read in; reading stops because the next character is a non-digit)
             ^
The parsed integer is 4193.
Since 4193 is in the range [-231, 231 - 1], the final result is 4193.
Example 4:
Input: s = "words and 987"
Output: 0
Explanation:
Step 1: "words and 987" (no characters read because there is no leading whitespace)
         ^
Step 2: "words and 987" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "words and 987" (reading stops immediately because there is a non-digit 'w')
         ^
The parsed integer is 0 because no digits were read.
Since 0 is in the range [-231, 231 - 1], the final result is 0.
Example 5:
Input: s = "-91283472332"
Output: -2147483648
Explanation:
Step 1: "-91283472332" (no characters read because there is no leading whitespace)
         ^
Step 2: "-91283472332" ('-' is read, so the result should be negative)
          ^
Step 3: "-91283472332" ("91283472332" is read in)
                     ^
The parsed integer is -91283472332.
Since -91283472332 is less than the lower bound of the range [-231, 231 - 1], the final result is clamped to -231 = -2147483648.
Constraints:
0 <= s.length <= 200
s consists of English letters (lower-case and upper-case), digits (0-9), ' ', '+', '-', and '.'.
**********************************************************************************/

namespace Algorithms
{
    public class Solution008
    {
        public static int MyAtoi(string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }
            int i = 0;
            int returnNumber = 0;
            bool isNegative = false;
            int startPoint = 0;
            str = str.Trim();
            if (str[0] == '-')
            {
                isNegative = true;
                startPoint = 1;
            }
            if (str[0] == '+')
            {
                startPoint = 1;
            }
            str = str.Trim();
            for (i = startPoint; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9' && str[i] != ' ')
                {
                    if (!isNegative)
                    {
                        if (returnNumber > int.MaxValue / 10 || (returnNumber == int.MaxValue / 10 && (str[i] > '7')))
                        {
                            return int.MaxValue;
                        }
                    }
                    else
                    {
                        if (returnNumber > int.MaxValue / 10 || (returnNumber == int.MaxValue / 10 && (str[i] > '8')))
                        {
                            return int.MinValue;
                        }
                    }
                    returnNumber = returnNumber * 10 + (str[i] - '0');
                }
                else
                {
                    break;
                }
            }
            return isNegative ? (-1 * returnNumber) : returnNumber;
        }
    }
}

