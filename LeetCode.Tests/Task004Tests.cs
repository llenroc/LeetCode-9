namespace LeetCode.Tests
{
    using LeetCode.Hard;
    using Xunit;

    public class Task004Tests
    {
        #region Public Methods

        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.0)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 2 }, new int[] { -2, -1 }, -1.0)]
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