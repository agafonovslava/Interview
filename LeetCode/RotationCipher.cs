//Rotational Cipher
//One simple way to encrypt a string is to "rotate" every alphanumeric character by a certain amount. Rotating a character means replacing it with another character that is a certain number of steps away in normal alphabetic or numerical order.
//For example, if the string "Zebra-493?" is rotated 3 places, the resulting string is "Cheud-726?". Every alphabetic character is replaced with the character 3 letters higher (wrapping around from Z to A), and every numeric character replaced with the character 3 digits higher (wrapping around from 9 to 0). Note that the non-alphanumeric characters remain unchanged.
//Given a string and a rotation factor, return an encrypted string.
//Signature
//string rotationalCipher(string input, int rotationFactor)
//Input
//1 <= | input | <= 1,000,000
//0 <= rotationFactor <= 1,000,000
//Output
//Return the result of rotating input a number of times equal to rotationFactor.
//Example 1
//input = Zebra-493?
//rotationFactor = 3
//output = Cheud-726?
//Example 2
//input = abcdefghijklmNOPQRSTUVWXYZ0123456789
//rotationFactor = 39
//output = nopqrstuvwxyzABCDEFGHIJKLM9012345678

using System;
using System.Collections.Generic;
using System.Text;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to
public class SolutionFacebook
{
    public static string rotationalCipher(String input, int rotationFactor)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (char.IsNumber(ch))
            {
                ch = (char)((ch + rotationFactor - 48) % 10 + 48);
            }
            else if (!char.IsLetter(ch))
            {
                sb.Append(ch);
                continue;
            }
            else if (char.IsUpper(ch))
            {
                ch = (char)((ch + rotationFactor - 65) % 26 + 65);
            }
            else
            {
                ch = (char)((ch + rotationFactor - 97) % 26 + 97);
            }
            sb.Append(ch);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Contiguous Subarrays
    /// You are given an array arr of N integers.For each index i, you are required to determine the number of contiguous subarrays that fulfill the following conditions:
    /// The value at index i must be the maximum element in the contiguous subarrays, and
    /// These contiguous subarrays must either start from or end on index i.
    /// Signature
    /// int[] countSubarrays(int[] arr)
    /// Input
    /// Array arr is a non-empty list of unique integers that range between 1 to 1,000,000,000
    /// Size N is between 1 and 1,000,000
    /// Output
    /// An array where each index i contains an integer denoting the maximum number of contiguous subarrays of arr[i]
    /// Example:
    /// arr = [3, 4, 1, 6, 2]
    /// output = [1, 3, 1, 5, 1]
    /// Explanation:
    /// For index 0 - [3] is the only contiguous subarray that starts(or ends) with 3, and the maximum value in this subarray is 3.
    /// For index 1 - [4], [3, 4], [4, 1]
    /// For index 2 - [1]
    /// For index 3 - [6], [6, 2], [1, 6], [4, 1, 6], [3, 4, 1, 6]
    /// For index 4 - [2]
    /// So, the answer for the above input is [1, 3, 1, 5, 1]
    /// </summary>
    /// <param name="arr"></param>
    /// <returns>O(N) time | O(N) space</returns>
    public static int[] countSubarrays(int[] arr)
    {
        Stack<int> stack = new Stack<int>();
        int[] ans = new int[arr.Length];
        //left
        for (int i = 0; i < arr.Length; i++)
        {
            while (stack.Count != 0 &&
                  arr[stack.Peek()] < arr[i])
            {
                ans[i] += ans[stack.Pop()];
            }
            stack.Push(i);
            ans[i]++;
        }
        stack.Clear();

        int[] temp = new int[arr.Length];
        //right
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            while (stack.Count != 0 &&
                  arr[stack.Peek()] < arr[i])
            {
                int idx = stack.Pop();
                ans[i] += temp[idx];
                temp[i] += temp[idx];
            }
            stack.Push(i);
            temp[i]++;
        }

        return ans;
    }
}