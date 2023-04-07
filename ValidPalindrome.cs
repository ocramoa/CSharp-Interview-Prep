using System.Linq.Expressions;
/**
Prompt:

A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.
 */

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            // Test code for our solution.
            Console.WriteLine(s.IsPalindrome(121));
            Console.WriteLine(s.strPalindrome("A man, a plan, a canal: Panama"));
        }


    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            // We do this if we have an integer. We first convert it to a string.
            var str = x.ToString();
            List<char> chars = new();
            chars.AddRange(str);
            // We simply reverse the list.
            List<char> chars2 = Enumerable.Reverse(chars).ToList();
            // If it is a valid palindrome, it will be the same at each position.
            for (int i = 0; i < chars2.Count; i++)
            {
                if (chars[i] != chars2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool strPalindrome(string x)
        {
            // We convert the input to a char list, strip it of whitespace, and rejoin.
            List<char> chars = new();
            string lower_x = x.ToLower();
            string[] stripped = lower_x.Split(" ");
            string joined = string.Join("", stripped);
            // If it is a valid letter or digit, we add it to the char list.
            foreach (char c in joined)
            {
                if (char.IsLetterOrDigit(c))
                {
                    chars.Add(c);
                }
            }
            // Once again, we reverse the list.
            List<char> chars2 = Enumerable.Reverse(chars).ToList();
            // We check each position again.
            for (int i = 0; i < chars2.Count;i++)
            {
                if (chars[i] != chars2[i])
                {
                    return false;
                }
            }
            return true;     
        }
    }
}