using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    class KthSmallestElementinaBSTProblem
    {
        // additional List is used, how can you reduce it further
        public int KthSmallest(TreeNode root, int k)
        {

            List<int> sortedvalues = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();

            while(root != null || s.Count >0)
            {
                while(root != null)
                {
                    s.Push(root);
                    root = root.left;
                }

                root = s.Pop();
                sortedvalues.Add(root.val);
                root = root.right;

            }          




            return sortedvalues[k-1];
        }

        // written to avoid Additional List
        public int KthSmallest2(TreeNode root, int k)
        {

           // List<int> sortedvalues = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();

            while (root != null || s.Count > 0)
            {
                while (root != null)
                {
                    s.Push(root);
                    root = root.left;
                }

                root = s.Pop();
                if (--k == 0) return root.val;
               // sortedvalues.Add(root.val);
                root = root.right;

            }




            return -1; //sortedvalues[k - 1];
        }
    }
}
