using LeetCodeV2;

class Program
{
    public void testing()
    {
        Console.WriteLine("testing");
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.testing();
        LinkedListLocal linkedListLocal = new LinkedListLocal();
        LinkedListLocal.Node head = new LinkedListLocal.Node(1);
        linkedListLocal.AppendToTail(head, 2);
        linkedListLocal.AppendToTail(head, 3);
        linkedListLocal.AppendToTail(head, 4);
        linkedListLocal.AppendToTail(head, 5);


        linkedListLocal.RemoveValueFromLinkedList(1, head);
    }
}