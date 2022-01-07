using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid.Length == 0) return 0;

            int islands = 0;
            int n = grid.Length;
            int m = grid[0].Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(i, j, m, n, grid);
                        islands++;
                    }
                }
            }

            return islands;

        }

        public void DFS(int i, int j, int m, int n, char[][] grid)
        {
            if (i < 0 || j < 0 || i >= n || j >= m || grid[i][j] == '0') return;

            grid[i][j] = '0'; // adajacent visited element will be marked 0
            DFS(i, j+1, m, n, grid);  // next element
            DFS(i, j - 1, m, n, grid); // behind element
            DFS(i-1, j, m, n, grid); // top element
            DFS(i+1, j, m, n, grid); // bottom element
         
        }


        public int NumIslandsusingBFS(char[][] grid)
        {
            if (grid.Length == 0) return 0;

            int islands = 0;
            int n = grid.Length;
            int m = grid[0].Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        BFS(i, j, m, n, grid);
                        islands++;
                    }
                }
            }

            return islands;

        }

        public void BFS(int i, int j, int m, int n, char[][] grid)
        {
            // this is a value tuple
            List<(int row, int col)> directions = new List<(int row, int col)>(){
                (0, 1),
                (1, 0),
                (-1, 0),
                (0, -1),
            };

       

            Queue<int[]> que = new Queue<int[]>();
            que.Enqueue(new int[] { i, j });
            grid[i][j] = '0';
            while(que.Count > 0)
            {
                var coor = que.Dequeue();

                foreach (var item in directions)
                {
                    int newx = coor[0] + item.row;
                    int newy = coor[1] + item.col;
                    if (newx < 0 || newy < 0 || newx >= n || newy >= m || grid[newx][newy] == '0')
                        continue;

                    grid[newx][newy] = '0';
                    que.Enqueue(new int[] { newx, newy });
                }
                
            }
          

        }




    }
}
