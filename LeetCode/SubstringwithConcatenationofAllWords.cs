// #30 : https://leetcode.com/problems/substring-with-concatenation-of-all-words/ 
/**********************************************************************************
* You are given a string, s, and a list of words, words, that are all of the same length. Find all starting indices of substring(s) in s that is a concatenation of each word in words exactly once and without any intervening characters.
* For example, given:
* s: "barfoothefoobarman"
* words: ["foo", "bar"]
* You should return the indices: [0,9].
* (order does not matter).
Example 1:
Input: s = "barfoothefoobarman", words = ["foo","bar"]
Output: [0,9]
Explanation: Substrings starting at index 0 and 9 are "barfoo" and "foobar" respectively.
The output order does not matter, returning [9,0] is fine too.
Example 2:
Input: s = "wordgoodgoodgoodbestword", words = ["word","good","best","word"]
Output: []
Example 3:
Input: s = "barfoofoobarthefoobarman", words = ["bar","foo","the"]
Output: [6,9,12]
Constraints:
1 <= s.length <= 104
s consists of lower-case English letters.
1 <= words.length <= 5000
1 <= words[i].length <= 30
words[i] consists of lower-case English letters.
**********************************************************************************/

using System.Collections.Generic;

namespace Algorithms
{
    public class Solution030
    {
        public static IList<int> FindSubstring(string s, string[] words)
        {
            var res = new List<int>();
            if (words.Length == 0 || s.Length == 0) 
                return res;
            var wordDict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordDict.ContainsKey(word))
                {
                    wordDict[word]++;
                }
                else
                {
                    wordDict.Add(word, 1);
                }
            }

            for (int i = 0; i <= s.Length - words[0].Length * words.Length; i++)
            {
                if (FoundAll(s.Substring(i, words[0].Length * words.Length), 
                    new Dictionary<string, int>(wordDict), words[0].Length))
                    res.Add(i);
            }

            return res;
        }

        private static bool FoundAll(string s, Dictionary<string, int> wordDict, int wordLength)
        {
            int i = 0;
            while (i <= s.Length - wordLength)
            {
                var sub = s.Substring(i, wordLength);
                if (!wordDict.ContainsKey(sub)) return false;
                if (wordDict[sub] > 1)
                {
                    wordDict[sub]--;
                }
                else
                {
                    wordDict.Remove(sub);
                }
                i += wordLength;
            }

            return wordDict.Count == 0;
        }
    }
}

