using System;
namespace Leetcode
{
    
  
 
    public class ReverseLinkedList
    {
        public ReverseLinkedList()
        {
        }

        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode leftList = head, midList = head, rightList = head;
            int i = 1;
            ListNode temp = leftList;
            while (i < left - 1 && temp != null)
            {
                temp = temp.next;
                midList = midList.next;
                i++;
            }
            midList = midList.next;
            i++;
            rightList = midList;
            ListNode temp2 = midList;
            while (i < right && rightList != null)
            {
                rightList = rightList.next;
                temp2 = temp2.next;
                i++;
            }
            rightList = rightList.next;
            temp2.next = null;
            var reversedList = ReverseList(midList, rightList);
            temp.next = reversedList;

            ListNode current = head;

            while (current.next != null)
            {
                current = current.next;
            }
            current.next = rightList;
            return head;
        }

        public ListNode ReverseList(ListNode mid, ListNode last)
        {

            ListNode next = null, prev = null, current = mid;
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
