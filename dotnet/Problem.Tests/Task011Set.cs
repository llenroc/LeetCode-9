namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Medium;
    using Xunit;

    public class Task011Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Medium")]
        [Trait("Topic", "Array")]
        [Trait("Topic", "Two Pointers")]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 2, 3, 4, 5, 18, 17, 6 }, 17)]
        public void CanMaxArea(int[] input, int expected)
        {
            // Arrange
            // Act
            var result = new Task011().MaxArea(input);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}