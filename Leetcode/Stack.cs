using System;
namespace Leetcode
{
    public class Stack
    {
        public StackValue top;
        public Stack(int data)
        {
            top = new StackValue();
            top.data = data;
        }
        public class StackValue
        {
            public int data;
            public StackValue next;            
        }        

        public StackValue push(int data)
        {
            StackValue stack = new StackValue();
            stack.data = data;
            stack.next = top;
            top = stack;
            return top;
        }

        public void Pop()
        {
            //int data = top.data;
            top = top.next;
            //return top;
        }

        public StackValue Peek()
        {            
            return top;
        }

        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            int i = 0, j = 0, counter = 0;
            while (counter <= pushed.Length + popped.Length )
            {
                if (i < pushed.Length )
                {
                    push(pushed[i]);
                    i++;
                }

                if (j < popped.Length  && top.data == popped[j])
                {
                    Pop();
                    j++;
                }
                counter++;
            }
            if (Peek() != null)
            {
                return true;
            }

            return false;
        }
    }
}
