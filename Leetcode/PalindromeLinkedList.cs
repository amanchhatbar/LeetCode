using System;
namespace Leetcode
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            //To move to the middle element of linked list have a fast and slow
            ListNode fast = head;
            ListNode slowReverse = head;
            ListNode secondHalf = new ListNode();
            while (slowReverse.next != null && fast.next != null && fast.next.next != null )
            {
                fast = fast.next.next;

                slowReverse = slowReverse.next;
            }
            var reverse = slowReverse.next;
            secondHalf = ReverseLinkedList(reverse);

            while(head.next != null && secondHalf.next != null)
            {
                if(head.val != secondHalf.val)
                {
                    return false;
                }

                head = head.next;
                secondHalf = secondHalf.next;
            }

            return true;
        }

        private ListNode ReverseLinkedList(ListNode node)
        {
            ListNode next = null, prev = null, current = node; //TODO important to make it null
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}

