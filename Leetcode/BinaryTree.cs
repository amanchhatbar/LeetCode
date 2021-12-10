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

        public bool DoesExist(int target, Node root)
        {
            if (root == null)
            {
                return false;
            }
            if (root.data == target)
            {
                return true;
            }

            if(DoesExist(target, root.left) || DoesExist(target, root.right))
            {
                return true;
            }          

            return false;
        }

        public int TreeSum( Node root)
        {
            int sum = 0;

            stack.Push(root);
            while(stack.Count > 0)
            {
                var popped = (Node)stack.Pop();
                sum += popped.data;

                if (popped.right != null) stack.Push(popped.right);
                if (popped.left != null) stack.Push(popped.left);
            }

            return sum;
        }

        public int TreeSumRecursive(Node root)
        {

            if(root== null)
            {
                return 0;
            }

            return root.data + TreeSumRecursive(root.left) + TreeSumRecursive(root.right); 
        }

        public int TreeMin(Node root)
        {
            int min = int.MaxValue;

            stack.Push(root);
            while (stack.Count > 0)
            {
                var popped = (Node)stack.Pop();
                if(min > popped.data)
                {
                    min = popped.data;
                }

                if (popped.right != null) stack.Push(popped.right);
                if (popped.left != null) stack.Push(popped.left);
            }

            return min;
        }


        public int MaxPathSumn(Node root)
        {
            if (root == null) return int.MinValue;

            if (root.left == null && root.right == null) return root.data;

            var leftChild = MaxPathSumn(root.left);
            var rightChild = MaxPathSumn(root.right);

            var maxValue = leftChild > rightChild ? leftChild : rightChild;

            return root.data + maxValue;
        }

        public bool IsSameTree(Node p, Node q)
        {

            var result = recursion(p, q);

            return result;
        }

        public bool recursion(Node p, Node q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            if (p.data == q.data)
            {
                return recursion(p.left, q.left) && recursion(p.right, q.right);
            }
            return false;

        }


        public bool IsSymmetric(Node root)
        {
            if (root == null) return true;
            var leftDFS = LeftDFS(root);

            var rightDFSs = rightDFS(root);
            if (String.Compare(leftDFS, rightDFSs) == 0) return true;

            return false;
        }

        public string LeftDFS(Node root)
        {
            if (root == null) return "null";

            return root.data.ToString() + LeftDFS(root.left) + LeftDFS(root.right);
        }

        public string rightDFS(Node root)
        {
            if (root == null) return "null";

            return root.data.ToString() + rightDFS(root.right) + rightDFS(root.left);
        }

        public bool IsBalanced(Node root)
        {
            if (root == null) return true;
            var leftSubTreeHeight = GetHeight(root.left);
            var rightSubTreeHeight = GetHeight(root.right);
            return Math.Abs(leftSubTreeHeight - rightSubTreeHeight) <= 1;
        }

        public int GetHeight(Node root)
        {
            if (root == null) return 0;
            var leftHeight = GetHeight(root.left);
            var rightHeight = GetHeight(root.right);

            var maxHeight = leftHeight > rightHeight ? leftHeight : rightHeight;
            return maxHeight + 1;
        }

    }
}
