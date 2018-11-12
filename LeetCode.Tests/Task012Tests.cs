namespace LeetCode.Tests
{
    using LeetCode.Medium;
    using Xunit;

    public class Task012Tests
    {
        #region Public Methods

        [Theory]
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