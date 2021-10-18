using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Trees;

namespace DataStructures.BinarySearch
{
    class SearchinaBinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return root;
            if (root.val == val)
            {
                return root;
            }
            else
            {
                return val < root.val ? SearchBST(root.left, val) : SearchBST(root.right, val);
            }
        }

        //public TreeNode CheckValue(TreeNode root, int val)
        //{
        //    if (root != null)
        //    {
        //        if (root.val == val) return root;
        //        CheckValue(root.left, val);
        //        CheckValue(root.right, val);
        //    }
        //    return null;
        //}
    }
}
