namespace LeetCode.Tests
{
    using LeetCode.Easy;
    using Xunit;

    public class Task020Tests
    {
        #region Public Methods

        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
        [InlineData("]", false)]
        [InlineData("", true)]
        [InlineData("([]", false)]
        public void CanDetectIsValid(string input, bool expected)
        {
            // Arrange
            // Act
            var result = new Task020().IsValid(input);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}