namespace LeetCode.Problem.Easy
{
    using System;
    using System.Text;

    /// <summary>
    /// The count-and-say sequence is the sequence of integers with the first five terms as following:
    ///
    /// 1.     1
    /// 2.     11
    /// 3.     21
    /// 4.     1211
    /// 5.     111221
    ///
    /// 1 is read off as "one 1" or 11.
    /// 11 is read off as "two 1s" or 21.
    /// 21 is read off as "one 2, then one 1" or 1211.
    ///
    /// Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence.
    ///
    /// Note: Each term of the sequence of integers will be represented as a string.
    /// </summary>
    public class Task038
    {
        #region Public Methods

        public string CountAndSay(int n)
        {
            var result = "1";
            var builder = new StringBuilder();

            for (var i = 1; i < n; i++)
            {
                var start = result[0];
                var count = 1;

                for (var j = 1; j < result.Length; j++)
                {
                    if (start == result[j])
                    {
                        count++;
                    }
                    else
                    {
                        builder.Append(count);
                        builder.Append(start);
                        start = result[j];
                        count = 1;
                    }
                }

                builder.Append(count);
                builder.Append(start);

                result = builder.ToString();
            }

            return result;
        }

        #endregion Public Methods
    }
}