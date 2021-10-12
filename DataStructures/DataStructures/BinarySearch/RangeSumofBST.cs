using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using DataStructures.Trees;

namespace DataStructures.BinarySearch
{
    public class RangeSumofBST
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null) return 0;
            return (root.val > low && root.val < high ? root.val : 0) + RangeSumBST(root.left, low, high) +
                   RangeSumBST(root.right, low, high);
        }

        public int RangeSumBST2(TreeNode root, int low, int high)
        {
            if (root == null) return 0;
            if (root.val > low && root.val < high) return root.val;
            int leftvalue = RangeSumBST2(root.left, low, high);
            int rightvalue = RangeSumBST2(root.right, low, high);
            return root.val + leftvalue + rightvalue;

        }
    }
}
