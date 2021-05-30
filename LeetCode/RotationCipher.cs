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
                if (ch + rotationFactor > '9')
                {
                    ch = ((int.Parse(ch.ToString()) + rotationFactor) % 10).ToString().ToCharArray()[0];
                }
                else
                {
                    ch = (char)(ch + rotationFactor);
                }
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
}