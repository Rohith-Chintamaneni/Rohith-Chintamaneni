using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    class NumberofConnectedComponentsinanUndirectedGraphProblem
    {
        public int CountComponentsUsingDFS(int n, int[][] edges)
        {

            // convert edges array to Adjacent List
            int countofcomponents = 0;
            var visited = new bool[n];
            var stack = new Stack<int>();

            var adj = new List<List<int>>();
            for(int i=0; i< n; i++)
            {
                adj.Add(new List<int>());
            }
            // filling all adjacency list
            for(int i=0; i<edges.Length; i++)
            {
                adj[edges[i][0]].Add(edges[i][1]);
                adj[edges[i][1]].Add(edges[i][0]);
            }

            // since we can have disconnected graphs, we loop through all
            for (int i = 0; i < n; i++)
            {
                if (!visited[i]) // check if the graph is already visited
                {
                    countofcomponents++;
                    stack.Push(i);

                    while (stack.Count > 0)
                    {
                        // stack will always have nodes of int value
                        int current = stack.Pop();
                        visited[current] = true;
                        // look for all it's neighbours
                        foreach (var neighbour in adj[current])
                        {
                            if (!visited[neighbour]) stack.Push(neighbour);
                        }
                    }
                }

            }


                return countofcomponents;
        }

        public int CountComponentsUsingBFS(int n, int[][] edges)
        {

            // convert edges array to Adjacent List
            int countofcomponents = 0;
            var visited = new bool[n];
            var stack = new Queue<int>();

            var adj = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                adj.Add(new List<int>());
            }
            // filling all adjacency list
            for (int i = 0; i < edges.Length; i++)
            {
                adj[edges[i][0]].Add(edges[i][1]);
                adj[edges[i][1]].Add(edges[i][0]);
            }

            // since we can have disconnected graphs, we loop through all
            for (int i = 0; i < n; i++)
            {
                if (!visited[i]) // check if the graph is already visited
                {
                    countofcomponents++;
                    stack.Enqueue(i);

                    while (stack.Count > 0)
                    {
                        // stack will always have nodes of int value
                        int current = stack.Dequeue();
                        visited[current] = true;
                        // look for all it's neighbours
                        foreach (var neighbour in adj[current])
                        {
                            if (!visited[neighbour]) stack.Enqueue(neighbour);
                        }
                    }
                }

            }


            return countofcomponents;
        }
    }
}
