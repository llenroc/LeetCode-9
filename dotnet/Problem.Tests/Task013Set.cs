namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Easy;
    using Xunit;

    public class Task013Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Easy")]
        [Trait("Topic", "Math")]
        [Trait("Topic", "String")]
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