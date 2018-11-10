namespace LeetCode.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using LeetCode.Easy;
    using Xunit;

    public class Task007Tests
    {
        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        public void CanReverse(int input, int expected)
        {
            // Arrange
            // Act
            var result = new Task007().Reverse(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
