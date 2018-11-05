namespace LeetCode.Tests
{
    using LeetCode.Easy;
    using Xunit;

    public class Task002Tests
    {
        #region Public Methods

        [Theory]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [InlineData(new int[] { 1, 8 }, new int[] { 0 }, new int[] { 1, 8 })]
        [InlineData(new int[] { 9, 8 }, new int[] { 1 }, new int[] { 0, 9 })]
        [InlineData(new int[] { 1 }, new int[] { 9, 9 }, new int[] { 0, 0, 1 })]
        public void CanAddTwoNumbers(int[] num1, int[] num2, int[] expected)
        {
            // Arrange
            var list1 = Task002.ListNode.Assemble(num1);
            var list2 = Task002.ListNode.Assemble(num2);

            // Act
            var result = new Task002().AddTwoNumbers(list1, list2);

            // Assert
            Assert.Equal(expected, Task002.ListNode.ToArray(result));
        }

        #endregion Public Methods
    }
}