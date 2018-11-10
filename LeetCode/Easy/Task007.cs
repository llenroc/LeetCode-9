using System;

namespace LeetCode.Easy
{
    /// <summary>
    /// Given a 32-bit signed integer, reverse digits of an integer.
    ///
    /// Example 1:
    /// Input: 123
    /// Output: 321
    ///
    /// Example 2:
    /// Input: -123
    /// Output: -321
    ///
    /// Example 3:
    /// Input: 120
    /// Output: 21
    ///
    /// Note:
    /// Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−2^31,  2^31 − 1].
    /// For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
    /// </summary>
    public class Task007
    {
        #region Public Methods

        public int Reverse(int x)
        {
            var result = default(int);
            var part = default(long);

            while (x != 0)
            {
                var digit = x % 10;

                part = (long)result * 10 + digit;

                result = part > int.MaxValue || part < int.MinValue 
                    ? 0
                    : (int)part;

                x = (x - digit) / 10;
            }

            return result;
        }

        #endregion Public Methods
    }
}