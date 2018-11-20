namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Medium;
    using Xunit;

    public class Task008Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Medium")]
        [InlineData("42", 42)]
        [InlineData("-42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        [InlineData("-2147483647", -2147483647)]
        [InlineData("-2147483649", -2147483648)]
        [InlineData("-91283472332", -2147483648)]
        [InlineData("-6147483648", -2147483648)]
        [InlineData("2147483800", 2147483647)]
        [InlineData("2147483648", 2147483647)]
        [InlineData("2147483646", 2147483646)]
        [InlineData("+1", 1)]
        [InlineData("+-2", 0)]
        public void CanMyAtoi(string input, int expected)
        {
            // Arrange
            // Act
            var result = new Task008().MyAtoi(input);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}