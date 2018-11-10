namespace LeetCode.Easy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Given a 32-bit signed integer, reverse digits of an integer.
    /// 
    /// Example 1:
    /// Input: 123
    /// Output: 321
    ///
    /// Example 2:
    /// Input: -123
    /// Output: -321
    /// 
    /// Example 3:
    /// Input: 120
    /// Output: 21
    /// 
    /// Note:
    /// Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−2^31,  2^31 − 1]. 
    /// For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
    /// </summary>
    public class Task007
    {
        public int Reverse(int x)
        {
            var negative = default(bool);
            var y = x.ToString();
            if (y[0] == '-')
            {
                negative = true;
                y = y.Substring(1);
            }
            var z = y.Reverse();

            var result = default(int);

            try
            {
                result = int.Parse(new string(z.ToArray()));
            }
            catch
            {
            }

            return negative
                ? -result
                : result;
        }
    }
}
