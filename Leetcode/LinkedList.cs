using System;
namespace Leetcode
{
    public class LinkedList
    {
        public class Node
        {
            public int data;
            public Node next = null;
            public Node(int _data, Node _next = null)
            {
                this.data = _data;
                this.next = _next;
            }
        }

        public void AddNode(Node head, int data)
        {
            Node newNode = new Node(data);
            Node current = head;

            while(current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
        }
               
    }
}
