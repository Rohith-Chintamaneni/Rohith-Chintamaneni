using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    class PrintAdjacentGraphProblem
    {
        public List<List<int>> PrintGraph(int v, List<List<int>> adj)
        {
            var ans = new List<List<int>>();

            for(int i=0; i< adj.Count; i++)
            {
                var temp = new List<int>();
               // temp.Add(i);
                for(int j=0; j<adj[i].Count; j++)
                {
                    temp.Add(adj[i][j]);
                }
                ans.Add(temp);
            }
            return ans;
        }
         // two vertices
        public List<List<int>> AddEdge(List<List<int>> adj ,int u, int v)
        {
            adj[u].Add(v);
            adj[v].Add(u);

            return adj;
        }
    }
}
