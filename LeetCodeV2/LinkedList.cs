namespace LeetCodeV2;

public class LinkedListLocal
{
    public class Node
    {
        public Node? next;
        public int _data;
        public Node? prev;

        public Node(int data)
        {
            _data = data;
        }
    }
    

    public void AppendToTail(Node head, int value)
    {
        Node newNode = new Node(value);
        while (head.next != null)
        {
            head = head.next;
        }
        head.next = newNode;
    }

    public Node? RemoveValueFromLinkedList(int value, Node root)
    {
        var newNode = new Node();
    }
}