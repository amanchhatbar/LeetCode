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
        public Node Root;
        

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

       

    }
}
