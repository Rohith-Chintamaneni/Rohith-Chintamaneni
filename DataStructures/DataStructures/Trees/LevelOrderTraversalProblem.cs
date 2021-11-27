using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    class LevelOrderTraversalProblem
    {
        List<IList<int>> result = new List<IList<int>>();

        // DFS Approach: Such a brilliant solution! To be more specific than stating it uses DFS, I would like to say that it implements pre-order traversal to realize level-order traversal. Each time we add root.val into the list, and then look at left and right child.
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            
            if (root == null)
                return result;
            TraverseTree(root, 0);
            return result;
        }

        private void TraverseTree(TreeNode root, int level)
        {
            if (result.Count <= level)
                result.Add(new List<int>());

            result[level].Add(root.val);

            TreeNode left = root.left;
            TreeNode right = root.right;
            if (left != null)
                TraverseTree(left, level + 1);
            if (right != null)
                TraverseTree(right, level + 1);
        }


        // Level order traversal using Iterative Solution: TO DO

    }
}
