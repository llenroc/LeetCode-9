namespace LeetCode.Tests
{
    using LeetCode.Easy;
    using Xunit;

    public class Task001Tests
    {
        #region Public Methods

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
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