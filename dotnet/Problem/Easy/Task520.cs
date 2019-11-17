namespace LeetCode.Problem.Easy
{
    /// <summary>
    /// Given a word, you need to judge whether the usage of capitals in it is right or not.
    ///
    /// We define the usage of capitals in a word to be right when one of the following cases holds:
    ///
    /// All letters in this word are capitals, like "USA".
    /// All letters in this word are not capitals, like "leetcode".
    /// Only the first letter in this word is capital, like "Google".
    /// Otherwise, we define that this word doesn't use capitals in a right way.
    /// </summary>
    public class Task520
    {
        #region Public Methods

        public bool DetectCapitalUse(string word)
        {
            var signal = default(ulong);

            for (var i = word.Length - 1; i >= 0; i--)
            {
                if (word[i] >> 5 == 2)
                {
                    signal |= 1;
                }

                signal <<= 1;
            }

            return ((signal | 2) == 2) || ((signal >> 1) ^ ~(ulong.MaxValue << word.Length)) == 0;
        }

        #endregion Public Methods
    }
}