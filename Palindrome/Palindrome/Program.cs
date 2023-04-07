using System.Linq.Expressions;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new();
            Console.WriteLine(s.IsPalindrome(121));
            Console.WriteLine(s.strPalindrome("A man, a plan, a canal: Panama"));
        }


    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            var str = x.ToString();
            List<char> chars = new();
            chars.AddRange(str);

            List<char> chars2 = Enumerable.Reverse(chars).ToList();

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
            List<char> chars = new();
            string lower_x = x.ToLower();
            string[] stripped = lower_x.Split(" ");
            string joined = string.Join("", stripped);

            foreach (char c in joined)
            {
                if (char.IsLetterOrDigit(c))
                {
                    chars.Add(c);
                }
            }

            List<char> chars2 = Enumerable.Reverse(chars).ToList();

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