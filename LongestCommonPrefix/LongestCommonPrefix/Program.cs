using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution S = new();
            string[] test1 = new string[] { "ab", "a" };
            var first = S.LCP(test1);
            Console.WriteLine(first);
        }
    }

    public class Solution
    {
        public string LCP(string[] strs)
        {
            // If we are given an empty list, give back an empty string.
            if (strs.Length== 0)
            {
                return "";
            }
            // Create a string named word that is the first item in the strs list.
            string word = strs[0];
            // Starting at index 0, iterate through each character in the word one at a time.
            for (int i = 0; i < word.Length; i++) 
            { 
            // Store the character at index i in the word.
            char c = word[i];
            // For the other words in the list, if their character at index i is not equal to c or if index i is equal to the length of the word, return the original word up until index i.   
                for (int j = 0; j < strs.Length; j++)
                {
            // The length check has to be first -- otherwise it might fail if the second word is shorter
                    if (i == strs[j].Length || strs[j][i] != c)
                    {
                        return word.Substring(0, i);
                    }
                }
            }
            // If there are no common prefixes return the word.
            return word;
        }
    }
}