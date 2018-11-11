namespace LeetCode.Tests
{
    using LeetCode.Easy;
    using Xunit;

    public class Task013Tests
    {
        #region Public Methods

        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("MCMXCIV", 1994)]
        public void CanRomanToInt(string input, int expected)
        {
            // Arrange
            // Act
            var result = new Task013().RomanToInt(input);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}