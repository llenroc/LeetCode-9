namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Easy;
    using Xunit;

    public class Task021Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Easy")]
        [Trait("Topic", "Linked List")]
        [InlineData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { }, new[] { 0 }, new[] { 0 })]
        public void CanMergeTwoLists(int[] num1, int[] num2, int[] expected)
        {
            // Arrange
            var list1 = Task021.ListNode.Assemble(num1);
            var list2 = Task021.ListNode.Assemble(num2);

            // Act
            var result = new Task021().MergeTwoLists(list1, list2);

            // Assert
            Assert.Equal(expected, Task021.ListNode.ToArray(result));
        }

        #endregion Public Methods
    }
}