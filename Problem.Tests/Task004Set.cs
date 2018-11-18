namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Hard;
    using Xunit;

    public class Task004Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Hard")]
        [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.0)]
        [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        [InlineData(new[] { 2 }, new[] { -2, -1 }, -1.0)]
        public void CanFindMedianSortedArrays(int[] nums1, int[] nums2, double expected)
        {
            // Arrange
            // Act
            var result = new Task004().FindMedianSortedArrays(nums1, nums2);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}