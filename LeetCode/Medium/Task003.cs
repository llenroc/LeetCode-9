namespace LeetCode.Medium
{
    using System.Collections.Generic;

    /// <summary>
    /// Given a string, find the length of the longest substring without repeating characters.
    ///
    /// Example 1:
    /// Input: "abcabcbb"
    /// Output: 3
    /// Explanation: The answer is "abc", with the length of 3.
    ///
    /// Example 2:
    /// Input: "bbbbb"
    /// Output: 1
    /// Explanation: The answer is "b", with the length of 1.
    ///
    /// Example 3:
    /// Input: "pwwkew"
    /// Output: 3
    /// Explanation: The answer is "wke", with the length of 3.
    ///
    /// Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
    /// </summary>
    public class Task003
    {
        #region Public Methods

        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var begin = default(int);
            var length = default(int);
            var position = default(int);
            var result = default(int);
            var hash = new int[128];

            for (var i = 0; i < s.Length; i++)
            {
                var symbol = s[i];
                position = hash[symbol];

                if (position >= begin)
                {
                    length = i - begin + 1;
                    result = (result > length)
                        ? result
                        : length;

                    begin = position + 1;
                }

                hash[symbol] = i + 1;
            }

            length = s.Length - begin + 1;

            return (result > length)
                ? result
                : length;
        }

        #endregion Public Methods
    }
}