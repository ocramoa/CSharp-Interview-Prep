/** 
Prompt:

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
*/

namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test code for our solution.
            Solution s2 = new();
            Console.WriteLine(s2.IsValid("(){}[]"));
            Console.WriteLine(s2.IsValid("{[]}"));
            Console.WriteLine(s2.IsValid("){"));
        }
    }

    public class Solution
    {
        // The following code looks quite messy. This is because we first have to catch a few edge cases.
        // After that, we want to solve this problem with a Stack data structure.
        // In case you aren't familiar with a Stack, it follows a Last In First Out pattern.
        bool result = false;
        public char[] leftSide = { '(', '[', '{' };
        public Dictionary<char, char> rightSide = new Dictionary<char, char>() { { ')', '(' }, { ']', '[' }, { '}', '{' } };
        private Stack<char> stack = new();

        public bool IsValid(string s)
        {
            // If the string is one character or less return false
            if (s.Length <= 1)
            {
                return false;
            }

            // if the string begins with a close paren return false
            bool isFirstCharacterClosed = rightSide.ContainsKey(s[0]);
            if (isFirstCharacterClosed)
            {
                return false;
            }

            // if the string ends with an open paren return false
            char isLastCharacterOpen = s[s.Length - 1];
            if (leftSide.Contains(isLastCharacterOpen))
            {
                return false;
            }

            // iteration
            foreach (char c in s)
            {
                // if the character is an open paren, push it to the stack    
                if (leftSide.Contains(c))
                {
                    stack.Push(c);
                }
                // if it's a closed paren, pop the last item from the stack and check if it's the corresponding closed paren    
                else if (rightSide.ContainsKey(c))
                {
                    try
                    {
                        char lastItem = stack.Pop();
                        if (lastItem == rightSide[c])
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                // if the stack is empty return false    
                    catch (InvalidOperationException)
                    {
                        return false;
                    }
                }
            }

            // if the stack is empty return true otherwise return false
            if (stack.Count == 0)
            {
                result = true;
            }
            else
            {
                return false;
            }

            if (result) { return true; }
            return false;
        }
    }
}