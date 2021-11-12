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
            
            while (slowReverse.next != null && fast.next != null && fast.next.next != null )
            {
                fast = fast.next.next;

                slowReverse = slowReverse.next;
            }


            return false;
        }

        private void ReverseLinkedList()
        {

        }
    }
}

