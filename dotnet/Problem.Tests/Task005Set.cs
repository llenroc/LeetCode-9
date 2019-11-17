namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Medium;
    using Xunit;

    public class Task005Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Medium")]
        [Trait("Topic", "String")]
        [Trait("Topic", "Dynamic Programming")]
        [InlineData("babad", "bab")]
        [InlineData("babad", "aba")]
        [InlineData("cbbd", "bb")]
        public void CanFindLongestPalindrome(string input, string expected)
        {
            // Arrange
            // Act
            // var result = new Task005().LongestPalindrome(input);

            // Assert
            // Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}