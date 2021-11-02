
using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class Graph_BFS
    {
        List<List<int>> input = new List<List<int>>();
        System.Collections.Queue queue = new System.Collections.Queue();
        public Graph_BFS()
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

        public void BFS(int startPosition)
        {
            queue.Enqueue(startPosition);

            while(queue.Count > 0)
            {
                var dequeueValue = Convert.ToInt32(queue.Dequeue());
                Console.WriteLine(dequeueValue);
                var neigh = input[dequeueValue];
                foreach (var item in neigh)
                {
                    queue.Enqueue(item);
                }
            }
        }

        
    }
}

