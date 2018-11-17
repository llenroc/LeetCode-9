namespace LeetCode.Easy
{
    using System.Collections.Generic;

    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    ///
    /// Example:
    /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    /// Output: 7 -> 0 -> 8
    /// Explanation: 342 + 465 = 807.
    /// </summary>
    public class Task002
    {
        #region Public Methods

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(default(int))
            {
                next = new ListNode(default(int))
            };

            var current = result;
            var overflow = default(int);

            var temp1 = l1;
            var temp2 = l2;

            while (temp1 != null || temp2 != null)
            {
                var value = (temp1 != null ? temp1.val : 0) + (temp2 != null ? temp2.val : 0) + overflow;

                if (value > 9)
                {
                    current.next = new ListNode(value % 10);
                    overflow = 1;
                }
                else
                {
                    current.next = new ListNode(value);
                    overflow = 0;
                }

                temp1 = temp1?.next;
                temp2 = temp2?.next;
                current = current?.next;
            }

            if (overflow > 0)
            {
                current.next = new ListNode(1);
            }

            return result.next;
        }

        #endregion Public Methods

        #region Public Classes

        public class ListNode
        {
            #region Public Fields

            public ListNode next;
            public int val;

            #endregion Public Fields

            #region Public Constructors

            public ListNode(int x)
            {
                val = x;
            }

            #endregion Public Constructors

            #region Public Methods

            public static ListNode Assemble(int[] num)
            {
                var result = new ListNode(num[0]);
                var temp = result;

                for (var i = 1; i < num.Length; i++)
                {
                    temp.next = new ListNode(num[i]);
                    temp = temp.next;
                }

                return result;
            }

            public static int[] ToArray(ListNode num)
            {
                var result = new List<int>();
                var temp = num;

                do
                {
                    result.Add(temp.val);
                    temp = temp.next;
                } while (temp != null);

                return result.ToArray();
            }

            public override string ToString() => 
                string.Join(", ", ToArray(this));

            #endregion Public Methods
        }

        #endregion Public Classes
    }
}