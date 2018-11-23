﻿namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Easy;
    using Xunit;

    public class Task001Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Easy")]
        [Trait("Topic", "Array")]
        [Trait("Topic", "Hash Table")]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        [InlineData(new[] { 0, 4, 3, 0 }, 0, new[] { 0, 3 })]
        [InlineData(new[] { -3, 4, 3, 90 }, 0, new[] { 0, 2 })]
        public void CanTwoSum(int[] nums, int target, int[] expected)
        {
            // Arrange
            // Act
            var result = new Task001().TwoSum(nums, target);

            // Assert
            foreach (var value in expected)
            {
                Assert.Contains(value, result);
            }
        }

        #endregion Public Methods
    }
}