using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearch
{
    class SumofLeftLeaves
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            // checking the base root

            return SumOfLeftLeavesHelper(root, false);

        }
        public int SumOfLeftLeavesHelper(TreeNode root, bool isleft)
        {
            if (root == null) return 0;

            if (root.left == null && root.right == null && isleft) return root.val;

           return SumOfLeftLeavesHelper(root.left, true) + SumOfLeftLeavesHelper(root.right, false);

        }

        public int SumOfAllLeaves(TreeNode root)
        {
            // checking the base root

            return SumOfAllLeavesHelper(root);


        }
        public int SumOfAllLeavesHelper(TreeNode root)
        {
            if (root == null) return 0;

           return root.val + SumOfAllLeavesHelper(root.left)+ SumOfAllLeavesHelper(root.right);
           
            
        }
    }
}
