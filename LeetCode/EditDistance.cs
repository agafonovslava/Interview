// Source : https://leetcode.com/problems/edit-distance 

/**********************************************************************************
*
* 
* Given two words word1 and word2, find the minimum number of steps required to convert word1 to word2. 
* (each operation is counted as 1 step.)
* 
* 
* You have the following 3 operations permitted on a word:
* 
* a) Insert a character
* b) Delete a character
* c) Replace a character
* 
*
**********************************************************************************/

using System;
namespace Algorithms
{
    public class Solution072
    {
        public static int MinDistance(string word1, string word2)
        {
            var l1 = word1.Length + 1;
            var l2 = word2.Length + 1;

            int[,] d = new int[l1, l2];
            d[0, 0] = 0;
            for (int i = 1; i <= word1.Length; i++) d[i, 0] = i;
            for (int j = 1; j <= word2.Length; j++) d[0, j] = j;
            for (int i = 1; i <= word1.Length; i++)
            {
                for (int j = 1; j <= word2.Length; j++)
                {
                    if (word1[i - 1] == word2[j - 1]) d[i, j] = d[i - 1, j - 1];
                    else d[i, j] = Math.Min(Math.Min(d[i - 1, j], d[i, j - 1]), d[i - 1, j - 1]) + 1;
                }
            }
            return d[word1.Length, word2.Length];
        }
    }
}

