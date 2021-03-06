// #68 : https://leetcode.com/problems/text-justification/ 

/**********************************************************************************
* Given an array of words and a length L, format the text such that each line has exactly L characters and is fully (left and right) justified.
* You should pack your words in a greedy approach; that is, pack as many words as you can in each line. Pad extra spaces ' ' when necessary so that each line has exactly L characters.
* Extra spaces between words should be distributed as evenly as possible. If the number of spaces on a line do not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.
* For the last line of text, it should be left justified and no extra space is inserted between words.
* For example,
* words: ["This", "is", "an", "example", "of", "text", "justification."]
* L: 16.
* Return the formatted lines as:
* [
*    "This    is    an",
*    "example  of text",
*    "justification.  "
* ]
* 
* Note: Each word is guaranteed not to exceed L in length.
* click to show corner cases.
* Corner Cases:
* A line other than the last line might contain only one word. What should you do in this case?
* In this case, that line should be left-justified.
Example 1:
Input: words = ["This", "is", "an", "example", "of", "text", "justification."], maxWidth = 16
Output:
[
   "This    is    an",
   "example  of text",
   "justification.  "
]
Example 2:
Input: words = ["What","must","be","acknowledgment","shall","be"], maxWidth = 16
Output:
[
  "What   must   be",
  "acknowledgment  ",
  "shall be        "
]
Explanation: Note that the last line is "shall be    " instead of "shall     be", because the last line must be left-justified instead of fully-justified.
Note that the second line is also left-justified becase it contains only one word.
Example 3:
Input: words = ["Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"], maxWidth = 20
Output:
[
  "Science  is  what we",
  "understand      well",
  "enough to explain to",
  "a  computer.  Art is",
  "everything  else  we",
  "do                  "
]*
**********************************************************************************/

using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Solution068
    {
        /// <summary>
        /// https://www.programmersought.com/article/60306316574/
        /// </summary>
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> result = new List<string>();
            int start = 0, end = 1, n = words.Length;
            while (start < n)
            {
                int compulsorySpaces = 0; //Required spaces, the number of currently selected words -1
                int wordLength = words[start].Length;//The current number of words
                while (end < n && compulsorySpaces + 1 + wordLength + words[end].Length <= maxWidth)
                { //Try to choose the largest number of words
                    compulsorySpaces++;
                    wordLength += words[end].Length;
                    end++;
                }

                if (end == n)
                { //Special treatment on the last line
                    StringBuilder sb = new StringBuilder(words[start]);
                    for (int k = start + 1; k < end; k++)
                        sb.Append(" " + words[k]);
                    for (int k = wordLength + compulsorySpaces; k < maxWidth; k++)
                        sb.Append(" ");
                    result.Add(sb.ToString());
                    break;
                }

                if (end - start == 1)
                { //Special treatment for only the selected one, because the calculation space does not appear to be divided by 0
                    StringBuilder sb = new StringBuilder(words[start]);
                    for (int k = wordLength; k < maxWidth; k++)
                        sb.Append(" ");
                    result.Add(sb.ToString());
                }
                else
                {//Handle multiple spaces
                    int space = (maxWidth - wordLength) / (end - start - 1); //Basic space
                    int remains = maxWidth - wordLength - (end - start - 1) * space; //The number of spaces that could not be allocated because of divisible
                    StringBuilder sb = new StringBuilder(words[start]);
                    for (int k = start + 1; k < end; k++)
                    {
                        for (int l = 0; l < space; l++)
                            sb.Append(" ");
                        if (remains-- > 0)
                            sb.Append(" "); //When it is greater than 0, that is, when you need to add more spaces on the left, give one more
                        sb.Append(words[k]);

                    }
                    result.Add(sb.ToString());
                }
                start = end;
                end = end + 1;
            }
            return result;
        }
    }
}

