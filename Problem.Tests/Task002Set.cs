namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Easy;
    using Xunit;

    public class Task002Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Easy")]
        [Trait("Topic", "Linked List")]
        [Trait("Topic", "Math")]
        [InlineData(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
        [InlineData(new[] { 1, 8 }, new[] { 0 }, new[] { 1, 8 })]
        [InlineData(new[] { 9, 8 }, new[] { 1 }, new[] { 0, 9 })]
        [InlineData(new[] { 1 }, new[] { 9, 9 }, new[] { 0, 0, 1 })]
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