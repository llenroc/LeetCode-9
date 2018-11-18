namespace LeetCode.Problem.Easy
{
    using System.Linq;

    /// <summary>
    /// Write a function to find the longest common prefix string amongst an array of strings.
    /// If there is no common prefix, return an empty string "".
    /// Example 1:
    /// Input: ["flower","flow","flight"]
    /// Output: "fl"
    /// Example 2:
    /// Input: ["dog","racecar","car"]
    /// Output: ""
    /// Explanation: There is no common prefix among the input strings.
    /// Note:
    /// All given inputs are in lowercase letters a-z.
    /// </summary>
    public class Task014
    {
        #region Public Methods

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs.Any(x => x.Length == 0))
            {
                return string.Empty;
            }

            if (strs.Length == 1)
            {
                return strs.First();
            }

            for (var i = 0; i < strs.First().Length; i++)
            {
                for (var j = 0; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != strs.First()[i])
                    {
                        return strs.First().Substring(0, i);
                    }
                }
            }

            return strs.First();
        }

        #endregion Public Methods
    }
}