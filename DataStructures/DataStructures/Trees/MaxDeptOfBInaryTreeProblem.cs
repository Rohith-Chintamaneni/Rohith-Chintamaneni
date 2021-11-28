using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    class MaxDeptOfBInaryTreeProblem
    {
        private int answer = 0;
        public int MaxDepthTopDown(TreeNode root)
        {

            if (root == null) return 0;
            int depth = 1;
            MaxDepthTopDownHelper(root, depth);
            return answer;
        }
        // TOP DOWN APProach: 
        public void MaxDepthTopDownHelper(TreeNode root, int depth)
        {
            if (root == null) return;

            if (root.left == null && root.right == null)
                answer = Math.Max(depth, answer);

            MaxDepthTopDownHelper(root.left, depth + 1);
            MaxDepthTopDownHelper(root.right, depth + 1);
        }

        public int MaxDepthBottomUp(TreeNode root)
        {

            if (root == null) return 0;
            return MaxDepthBottomUpHelper(root);

        }

        public int MaxDepthBottomUpHelper(TreeNode root)
        {
            if (root == null) return 0;

            var left = MaxDepthBottomUpHelper(root.left);
            var right = MaxDepthBottomUpHelper(root.right);
            return Math.Max(left, right) + 1;
        }
    }
}
