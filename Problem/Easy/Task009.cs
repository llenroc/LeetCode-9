﻿namespace LeetCode.Problem.Easy
{
    /// <summary>
    /// Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.
    /// Example 1:
    /// Input: 121
    /// Output: true
    /// Example 2:
    /// Input: -121
    /// Output: false
    /// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    /// Example 3:
    /// Input: 10
    /// Output: false
    /// Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
    /// Follow up:
    /// Coud you solve it without converting the integer to a string?
    /// </summary>
    public class Task009
    {
        #region Public Methods

        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var y = x;
            var reverse = default(int);

            while (y != 0)
            {
                reverse = reverse * 10 + y % 10;
                y /= 10;
            }

            return reverse == x;
        }

        #endregion Public Methods
    }
}