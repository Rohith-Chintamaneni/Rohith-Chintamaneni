using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Trees;

namespace DataStructures.BinarySearch
{
    class IncreasingOrderSearchTree
    {
        private TreeNode node = new(0);
        public TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode pre = node;
            InOrderTraverse(root);
            return pre.right;
        }

        private void InOrderTraverse(TreeNode root)
        {
            if (root == null) return;
            InOrderTraverse(root.left);
            // Create a TreeNode
            root.left = null;
            node.right = node;
            node = root;
            InOrderTraverse(root.right);

        }
    }
}
