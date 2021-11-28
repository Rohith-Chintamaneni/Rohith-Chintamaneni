using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    class DiamterOfTreeProblem
    {

        // not working

        int result = -1;
        public int DiameterOfBinaryTree(TreeNode root)
        {
           
            DiameterOfBinaryTreeHelper(root);
                return result-1;

        }

        public int DiameterOfBinaryTreeHelper(TreeNode root)
        {
            if (root == null) return 0;

            var leftdiameter = DiameterOfBinaryTreeHelper(root.left);
            var rightdiameter = DiameterOfBinaryTreeHelper(root.right);

            var temp = Math.Max(leftdiameter, rightdiameter) + 1;
            var ans = Math.Max(temp, leftdiameter + rightdiameter + 1);
            result = Math.Max(temp, ans);

            return temp;
        }
    }
}
