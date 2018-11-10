﻿namespace LeetCode.Tests
{
    using LeetCode.Easy;
    using Xunit;

    public class Task007Tests
    {
        #region Public Methods

        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(1534236469, 0)]
        public void CanReverse(int input, int expected)
        {
            // Arrange
            // Act
            var result = new Task007().Reverse(input);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}