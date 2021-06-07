using System;

namespace Algorithms.Utils
{
    /// <summary>
    /// https://www.algoexpert.io/questions/Knuth%E2%80%94Morris%E2%80%94Pratt%20Algorithm
    /// Knuth-Morris-Pratt Algorithm
    /// Write a function that takes in two strings and checks if the first string contains the 
    /// second one using the Knuth-Morris-Pratt algorithm. The function should return a boolean.
    /// 
    /// The KMP algorithm works by identifying patterns in the potential substring and 
    /// exploiting them to avoid doing needless character comparisons when searching for 
    /// the substring in the main string. For instance, take the string "ababac" and the substring "abac"
    /// comparing these strings will fail at the fourth character where "b" is not equal to "c".
    /// Instead of having to restart our comparisons at the second character of the main string,
    /// however, we notice that the substring "ab", which is at the beginning of our potential
    /// substring, just appeared near our point of failure in the main string. 
    /// </summary>
    public class KMP
    {
        //O(n + m) time | O(m) space 
        public static bool KnuthMorrisPrattAlgorithm(string str, string substring)
        {
            int[] pattern = buildPattern(substring);
            return doesMatch(str, substring, pattern);
        }

        public static int[] buildPattern(string substring)
        {
            int[] pattern = new int[substring.Length];
            Array.Fill(pattern, -1);
            int j = 0;
            int i = 1;
            while (i < substring.Length)
            {
                if (substring[i] == substring[j])
                {
                    pattern[i] = j;
                    i++;
                    j++;
                }
                else if (j > 0)
                    j = pattern[j - 1] + 1;
                else
                    i++;
            }
            return pattern;
        }

        public static bool doesMatch(string str, string substring, int[] pattern)
        {
            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrWhiteSpace(substring))
                return false;

            int i = 0;
            int j = 0;
            while (i + substring.Length - j <= str.Length)
            {
                if (str[i] == substring[j])
                {
                    if (j == substring.Length - 1)
                        return true;
                    i++;
                    j++;
                }
                else if (j > 0)
                    j = pattern[j - 1] + 1;
                else
                    i++;
            }
            return false;
        }
    }
}