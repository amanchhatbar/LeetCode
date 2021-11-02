using System;
using System.Collections.Generic;

namespace Leetcode
{

    //a = 0 b = 1 c = 2 d = 3 e = 4 f = 5

    public class Graph_DFS
    {
        List<List<int>> input = new List<List<int>>();
        System.Collections.Stack stack = new System.Collections.Stack();
        public Graph_DFS()
        {
            input.Add(new List<int>()
           {
               1,2
               
           });
            input.Add(new List<int>()
           {
               3
           });
            input.Add(new List<int>()
           {
              4

           });
            input.Add(new List<int>()
           {
               5
           });
            input.Add(new List<int>()
           {
               
           });
            input.Add(new List<int>()
           {
              
           });
        }


        public void DFS(int startPosition)
        {
            stack.Push(startPosition);

            while(stack.Count > 0)
            {
                var poppedValue = Convert.ToInt32(stack.Pop());
                Console.WriteLine(poppedValue);

                var getPoppedNeighbours = input[poppedValue];

                foreach (var item in getPoppedNeighbours)
                {
                    stack.Push(item);                    
                }
            }
        }


        public void DFS_Recursive(int startPosition)
        {
            Console.WriteLine(startPosition);
            var getPoppedNeighbours = input[startPosition];
            foreach (var item in getPoppedNeighbours)
            {
                DFS_Recursive(item);
            }
        }
    }
}

