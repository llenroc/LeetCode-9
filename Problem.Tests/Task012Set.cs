namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Medium;
    using Xunit;

    public class Task012Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Medium")]
        [Trait("Topic", "Math")]
        [Trait("Topic", "String")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(1994, "MCMXCIV")]
        public void CanIntToRoman(int input, string expected)
        {
            // Arrange
            // Act
            var result = new Task012().IntToRoman(input);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}