namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s2 = new();
            Console.WriteLine(s2.IsValid("(){}[]"));
            Console.WriteLine(s2.IsValid("{[]}"));
            Console.WriteLine(s2.IsValid("){"));
        }
    }

    public class Solution
    {
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