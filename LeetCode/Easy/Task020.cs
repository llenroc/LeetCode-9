namespace LeetCode.Easy
{
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
            var stack = new char[s.Length + 1];
            var index = 1;

            foreach (var symbol in s)
            {
                if (symbol == '(' || symbol == '{' || symbol == '[')
                {
                    stack[index++] = symbol;
                }
                else if ((symbol == ')' && stack[--index] != '(')
                    || (symbol == '}' && stack[--index] != '{')
                    || (symbol == ']' && stack[--index] != '['))
                {
                    return false;
                }
            }

            return index == 1;
        }

        #endregion Public Methods
    }
}