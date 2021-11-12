using System;
namespace Leetcode
{
    public class RemoveLinkedListValue
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if(head == null)
            {
                return head;
            }

            ListNode prev = new ListNode();
            prev.next = head;
            ListNode current = prev;
            while (current.next != null)
            {
                if (current.next.val == val)
                {
                    current.next = current.next.next;
                }
                else
                {

                    current = current.next;
                }

            }

            return prev.next;
        }

    }
}

