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
            if (root == null)
                return false;

            Stack<TreeNode> node_stack = new Stack<TreeNode>();
            Stack<int> sum_stack = new Stack<int>();
            node_stack.Push(root);
         //   targetSum = targetSum - root.val;
            sum_stack.Push(targetSum - root.val);

            TreeNode node;
            int curr_sum;
            while (node_stack.Count > 0)
            {
                
                node = node_stack.Pop();
                curr_sum = sum_stack.Pop();
                // this condition is so important and you are checking to make sure you reached to the bottom of the tree.
                // if not this is just going to traverse in preorder and all node values will be summed
                if ((node.right == null) && (node.left == null) && (curr_sum == 0))
                    return true;

                if (node.right != null)
                {
                    node_stack.Push(node.right);
                    sum_stack.Push(curr_sum - node.right.val);
                }
                if (node.left != null)
                {
                    node_stack.Push(node.left);
                    sum_stack.Push(curr_sum - node.left.val);
                }
            }
            return false;
        }



       
    }
}
