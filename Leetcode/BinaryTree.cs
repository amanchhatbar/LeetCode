using System;
namespace Leetcode
{

    public class Node
    {
        public int data;
        public Node left = null;
        public Node right = null;

        public Node(int _data)
        {
            data = _data;
        }
    }

    public class BinaryTree
    {
        System.Collections.Stack stack = new System.Collections.Stack();
        System.Collections.Queue queue = new System.Collections.Queue();
        public Node Add(int data, Node root)
        {
            if(root == null)
            {
                return new Node(data);
            }

            if(root.data <= data)
            {
                root.right = Add(data, root.right);
            }

            else
            {
                root.left = Add(data, root.left);
            }

            return root;
        }


        public void DFS(Node root)
        {
            stack.Push(root);
            
            while(stack.Count > 0)
            {
                var poppedValue = (Node)stack.Pop();
                Console.WriteLine(poppedValue.data);
                if(poppedValue.right != null) stack.Push(poppedValue.right);
                if(poppedValue.left != null) stack.Push(poppedValue.left);
            }
        }

        public void DFS_Recursive(Node root)
        {
            if (root == null) return;
            Console.WriteLine(root.data);
            DFS_Recursive(root.left);
            DFS_Recursive(root.right);
        }


        public void BFS(Node root)
        {
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var poppedValue = (Node)queue.Dequeue();
                Console.WriteLine(poppedValue.data);
                if (poppedValue.right != null) queue.Enqueue(poppedValue.right);
                if (poppedValue.left != null) queue.Enqueue(poppedValue.left);
            }
        }
    }
}
