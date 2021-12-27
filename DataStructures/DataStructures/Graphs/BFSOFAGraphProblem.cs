using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    class BFSOFAGraphProblem
    {
        //v is number of vertices and s is the source of the vertices
        // to return all vertices in a graph, you need to know the source vertices. Without know from where to start
        //
        //  0->1
        //  0->2
        //  1->2
        //  1->3
        // 
        public List<int> BFS(List<List<int>> adj, int v, int s)
        {

            var ans = new List<int>();
            // you need a stack
            var queue = new Queue<int>();
            var visited = new bool[v];
            visited[s] = true;
            ans.Add(s);
            queue.Enqueue(s);

          while(queue.Count >0)
           {
                int u = queue.Dequeue();
                foreach(var n in adj[u])
                {
                    if(visited[n] == false)
                    {
                        visited[n] = true;
                        queue.Enqueue(n);
                        ans.Add(n);
                    }
                }

           }

           return ans;
        }

        public void BFSOnDisconnectedWithNoSourceVertice(List<List<int>> adj,  int s, bool[] visited)
        {

            var ans = new List<int>();
            // you need a stack
            var queue = new Queue<int>();
        
            visited[s] = true;
            ans.Add(s);
            queue.Enqueue(s);

            while (queue.Count > 0)
            {
                int u = queue.Dequeue();
                Console.Write(u +" ");

                foreach (var n in adj[u])
                {
                    if (visited[n] == false)
                    {
                        visited[n] = true;
                        queue.Enqueue(n);
                        ans.Add(n);
                    }
                }

            }

            
        }

        public void BFSDIS(List<List<int>>  adj, int v)
        {
            var visited = new bool[v];

            for(int i=0; i<v; i++)
            {
                if (visited[i] == false)
                   BFSOnDisconnectedWithNoSourceVertice(adj, i, visited);
            }
        }
    }
}
