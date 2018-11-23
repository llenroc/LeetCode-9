namespace LeetCode.Problem.Medium
{
    /// <summary>
    /// Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate(i, ai). n vertical lines are drawn such that the two endpoints of line i is at(i, ai) and(i, 0).
    /// Find two lines, which together with x-axis forms a container, such that the container contains the most water.
    ///
    /// Note: You may not slant the container and n is at least 2.
    /// The above vertical lines are represented by array[1, 8, 6, 2, 5, 4, 8, 3, 7].
    /// In this case, the max area of water (blue section) the container can contain is 49.
    ///
    /// Example:
    /// Input: [1,8,6,2,5,4,8,3,7]
    /// Output: 49
    /// </summary>
    public class Task011
    {
        #region Public Methods

        public int MaxArea(int[] height)
        {
            var result = default(int);
            var area = default(int);
            var left = 0;
            var right = height.Length - 1;

            for (var i = 0; left < right; i++)
            {
                if (height[left] > height[right])
                {
                    area = height[right] * (right - left);
                    right--;
                }
                else
                {
                    area = height[left] * (right - left);
                    left++;
                }

                if (area > result)
                {
                    result = area;
                }
            }

            return result;
        }

        #endregion Public Methods
    }
}