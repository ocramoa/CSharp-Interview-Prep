/**
Prompt:

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
*/

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution S = new();
            // Some very short test code.
            string[] test1 = new string[] { "ab", "a" };
            var first = S.LCP(test1);
            Console.WriteLine(first);
        }
    }

    public class Solution
    {
        public string LCP(string[] strings)
        {
            // If we are given an empty list, give back an empty string.
            if (strings.Length== 0)
            {
                return "";
            }
            // Create a string named word that is the first item in the strings list.
            string word = strings[0];
            // Starting at index 0, iterate through each character in the word one at a time.
            // This is a brute force method.
            for (int i = 0; i < word.Length; i++) 
            { 
            // Store the character at index i in the word.
            char c = word[i];
            // For the other words in the list, if their character at index i is not equal to c or if index i is equal to the length of the word, return the original word up until index i.   
                for (int j = 0; j < strings.Length; j++)
                {
            // The length check has to be first -- otherwise it might fail if the second word is shorter
                    if (i == strings[j].Length || strings[j][i] != c)
                    {
                        // We use the BIF Substring here to record the characters up to our current index.
                        return word.Substring(0, i);
                    }
                }
            }
            // If there are no common prefixes return the word.
            return word;
        }
    }
}