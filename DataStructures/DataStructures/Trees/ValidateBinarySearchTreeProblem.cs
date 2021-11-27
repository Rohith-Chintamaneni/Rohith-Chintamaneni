using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    class ValidateBinarySearchTreeProblem
    {
        public bool IsValidBST(TreeNode root)
        {
          return InOrderTraversal(root);
        }

        public bool InOrderTraversal(TreeNode root)
        {
            if (root == null) return true;

            Stack<TreeNode> S = new Stack<TreeNode>();
            var curr = root;
            TreeNode prev = null;

            while (S.Count > 0 || curr != null)
            {

                while (curr != null)
                {
                    S.Push(curr);
                    curr = curr.left;
                }
                curr = S.Pop();
                if (prev != null && prev.val >= curr.val) return false;
                prev = curr;
                curr = curr.right;
                //if(curr.val < S.Peek().val)
                //{
                //    curr = curr.right;
                //}


            }

            return true;
        }
    }
}
