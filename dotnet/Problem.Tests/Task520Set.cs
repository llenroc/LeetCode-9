namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Easy;
    using Xunit;

    public class Task520Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Easy")]
        [Trait("Topic", "String")]
        [InlineData("g", true)]
        [InlineData("Google", true)]
        [InlineData("leetcode", true)]
        [InlineData("Leetcode", true)]
        [InlineData("USA", true)]
        [InlineData("usa", true)]
        [InlineData("FFFFFFFFFFFFFFFFFFFFf", false)]
        [InlineData("ffffffffffffffffffffF", false)]
        [InlineData("aewfefaewfewajfioawejfowahfgewhgeiwahfiewhgiewahfEWWEEFEEFEGIUEGIEBGF", false)]
        public void CanDetectCapitalUse(string word, bool expected)
        {
            // Arrange
            // Act
            var result = new Task520().DetectCapitalUse(word);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}