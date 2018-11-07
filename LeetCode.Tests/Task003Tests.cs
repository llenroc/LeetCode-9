﻿namespace LeetCode.Tests
{
    using LeetCode.Medium;
    using Xunit;

    public class Task003Tests
    {
        #region Public Methods

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("pwwkew", 3)]
        [InlineData("aab", 2)]
        [InlineData("abba", 2)]
        [InlineData("cdd", 2)]
        [InlineData("dvdf", 3)]
        [InlineData("", 0)]
        [InlineData(" ", 1)]
        public void CanLengthOfLongestSubstring(string input, int expected)
        {
            // Arrange
            // Act
            var result = new Task003().LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}