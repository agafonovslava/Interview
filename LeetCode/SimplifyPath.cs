// #71 : https://leetcode.com/problems/simplify-path/ 
/**********************************************************************************
* Given an absolute path for a file (Unix-style), simplify it.
* For example,
* path = "/home/", => "/home"
* path = "/a/./b/../../c/", => "/c"
* click to show corner cases.
* Corner Cases:
* Did you consider the case where path = "/../"?
* In this case, you should return "/".
* Another corner case is the path might contain multiple slashes '/' together, such as "/home//foo/".
* In this case, you should ignore redundant slashes and return "/home/foo".
Example 1:
Input: path = "/home/"
Output: "/home"
Explanation: Note that there is no trailing slash after the last directory name.
Example 2:
Input: path = "/../"
Output: "/"
Explanation: Going one level up from the root directory is a no-op, as the root level is the highest level you can go.
Example 3:
Input: path = "/home//foo/"
Output: "/home/foo"
Explanation: In the canonical path, multiple consecutive slashes are replaced by a single one.
Example 4:
Input: path = "/a/./b/../../c/"
Output: "/c"
Constraints:
1 <= path.length <= 3000
path consists of English letters, digits, period '.', slash '/' or '_'.
path is a valid absolute Unix path.
**********************************************************************************/

using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Solution071
    {
        public static string SimplifyPath(string path)
        {
            if (path == null || path.Length == 0)
            {
                return "";
            }
            Stack<string> stack = new Stack<string>();
            StringBuilder res = new StringBuilder();
            int i = 0;

            while (i < path.Length)
            {
                int index = i;
                StringBuilder temp = new StringBuilder();
                while (i < path.Length && path[i] != '/')
                {
                    temp.Append(path[i]);
                    i++;
                }
                if (index != i)
                {
                    string str = temp.ToString();
                    if (str.Equals(".."))
                    {
                        if (stack.Count > 0)
                            stack.Pop();
                    }
                    else if (!str.Equals("."))
                    {
                        stack.Push(str);
                    }
                }
                i++;
            }
            if (stack.Count > 0)
            {
                string[] strs = stack.ToArray();
                for (int j = strs.Length - 1; j >= 0; j--)
                {
                    res.Append("/" + strs[j]);
                }
            }
            if (res.Length == 0) { return "/"; }
            return res.ToString();
        }
    }
}

