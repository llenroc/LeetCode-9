namespace LeetCode.Easy
{
    using System.Collections.Generic;

    /// <summary>
    /// Merge two sorted linked lists and return it as a new list.The new list should be made by splicing together the nodes of the first two lists.
    ///
    /// Example:
    ///
    /// Input: 1->2->4, 1->3->4
    /// Output: 1->1->2->3->4->4
    /// </summary>
    public class Task021
    {
        #region Public Methods

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            return default(ListNode);
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