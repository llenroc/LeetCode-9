namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Easy;
    using Xunit;

    public class Task020Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Easy")]
        [Trait("Topic", "String")]
        [Trait("Topic", "Stack")]
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