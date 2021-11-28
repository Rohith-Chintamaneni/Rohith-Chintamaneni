using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    class PathSumProblem
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            targetSum = targetSum - root.val;
            if (root.left == null && root.right == null)
                return (targetSum == 0);


            return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
        }

        // todo 
        public bool HasPathSumIterative(TreeNode root, int targetSum)
        {

            return true;
        }

    }
}
