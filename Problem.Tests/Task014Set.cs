namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Easy;
    using Xunit;

    public class Task014Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Easy")]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "", "" }, "")]
        [InlineData(new[] { "c", "c" }, "c")]
        public void CanDetectLongestCommonPrefix(string[] input, string expected)
        {
            // Arrange
            // Act
            var result = new Task014().LongestCommonPrefix(input);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}