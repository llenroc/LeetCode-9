namespace LeetCode.Tests
{
    using LeetCode.Easy;
    using Xunit;

    public class Task014Tests
    {
        #region Public Methods

        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        [InlineData(new string[] { "", "" }, "")]
        [InlineData(new string[] { "c", "c" }, "c")]
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