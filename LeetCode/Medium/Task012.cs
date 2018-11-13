namespace LeetCode.Medium
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    ///
    /// Symbol Value
    /// I             1
    /// V             5
    /// X             10
    /// L             50
    /// C             100
    /// D             500
    /// M             1000
    /// For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.
    ///
    /// Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:
    ///
    /// I can be placed before V (5) and X(10) to make 4 and 9.
    /// X can be placed before L(50) and C(100) to make 40 and 90.
    /// C can be placed before D(500) and M(1000) to make 400 and 900.
    /// Given an integer, convert it to a roman numeral.Input is guaranteed to be within the range from 1 to 3999.
    ///
    /// Example 1:
    /// Input: 3
    /// Output: "III"
    ///
    /// Example 2:
    /// Input: 4
    /// Output: "IV"
    ///
    /// Example 3:
    /// Input: 9
    /// Output: "IX"
    ///
    /// Example 4:
    /// Input: 58
    /// Output: "LVIII"
    /// Explanation: L = 50, V = 5, III = 3.
    ///
    /// Example 5:
    /// Input: 1994
    /// Output: "MCMXCIV"
    /// Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
    /// </summary>
    public class Task012
    {
        #region Public Methods

        public string IntToRoman(int num)
        {
            var digits = new Dictionary<int, char>
            {
                { 1, 'I' },
                { 5, 'V'},
                { 10, 'X' },
                { 50, 'L' },
                { 100, 'C' },
                { 500, 'D' },
                { 1000, 'M' }
            };

            var result = new StringBuilder();
            var part = default(int);
            var pivot = default(int);

            for (var i = 1; num != 0; i++)
            {
                pivot = (int)(Math.Pow(10, i));
                part = num % pivot;
                num -= part;

                var digit = (part % pivot) / Math.Pow(10, i - 1);

                switch (digit)
                {
                    case 1:
                    case 2:
                    case 3:
                        for (var j = 0; j < digit; j++)
                        {
                            result.Insert(0, digits[pivot / 10]);
                        }
                        break;

                    case 4:
                        result.Insert(0, digits[pivot / 2]);
                        result.Insert(0, digits[pivot / 10]);
                        break;

                    case 5:
                        result.Insert(0, digits[pivot / 2]);
                        break;

                    case 6:
                    case 7:
                    case 8:
                        for (var j = 0; j < digit % 5; j++)
                        {
                            result.Insert(0, digits[pivot / 10]);
                        }
                        result.Insert(0, digits[pivot / 2]);
                        break;

                    case 9:
                        result.Insert(0, digits[pivot]);
                        result.Insert(0, digits[pivot / 10]);
                        break;
                }
            }

            return result.ToString();
        }

        #endregion Public Methods
    }
}