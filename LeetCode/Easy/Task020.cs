namespace LeetCode.Easy
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    ///
    /// An input string is valid if:
    ///
    /// Open brackets must be closed by the same type of brackets.
    /// Open brackets must be closed in the correct order.
    /// Note that an empty string is also considered valid.
    ///
    /// Example 1:
    /// Input: "()"
    /// Output: true
    ///
    /// Example 2:
    /// Input: "()[]{}"
    /// Output: true
    ///
    /// Example 3:
    /// Input: "(]"
    /// Output: false
    ///
    /// Example 4:
    /// Input: "([)]"
    /// Output: false
    ///
    /// Example 5:
    /// Input: "{[]}"
    /// Output: true
    /// </summary>
    public class Task020
    {
        #region Public Methods

        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            var hash = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            var stack = new Stack<char>();

            foreach (var symbol in s)
            {
                if (hash.Keys.Contains(symbol))
                {
                    stack.Push(symbol);
                }
                else if (stack.Count == 0 || (stack.Count != 0 && hash[stack.Pop()] != symbol))
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }

        #endregion Public Methods
    }
}