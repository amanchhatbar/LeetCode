using System;
namespace Leetcode
{
    public class BinaryTree
    {
        public Node Root;
        public class Node
        {
            public int data;
            public Node left = null;
            public Node right = null;
        }

        public void Add(int data, Node root = null)
        {
            if(root == null)
            {
                Node newNode = new Node();
                newNode.data = data;
            }

            if(root.data <= data)
            {
                Add(data, root.right);
            }

            else
            {
                Add(data, root.left);
            }
        }


    }
}
