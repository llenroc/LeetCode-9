namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Easy;
    using Xunit;

    public class Task038Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Easy")]
        [Trait("Topic", "String")]
        [InlineData(1, "1")]
        [InlineData(2, "11")]
        [InlineData(3, "21")]
        [InlineData(4, "1211")]
        [InlineData(5, "111221")]
        [InlineData(6, "312211")]
        [InlineData(7, "13112221")]
        [InlineData(8, "1113213211")]
        [InlineData(9, "31131211131221")]
        [InlineData(10, "13211311123113112211")]
        public void CanCountAndSay(int number, string word)
        {
            // Arrange
            // Act
            var result = new Task038().CountAndSay(number);

            // Assert
            Assert.Equal(word, result);
        }

        #endregion Public Methods
    }
}