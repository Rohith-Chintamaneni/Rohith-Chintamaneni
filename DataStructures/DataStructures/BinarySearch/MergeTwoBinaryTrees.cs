using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Trees;

namespace DataStructures.BinarySearch
{
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
         
           return Merge(root1, root2);
            
        }

        public TreeNode Merge(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return null;

            if (root1 != null && root2 == null) return root1;

            if (root1 == null && root2 != null) return root2;
            // Recursively you are creating a new node
            TreeNode sum = new TreeNode(root1.val + root2.val);

            sum.left = Merge(root1.left, root2.left);
            sum.right = Merge(root1.right, root2.right);

            return sum;

        }
        public TreeNode MergeTrees2(TreeNode root1, TreeNode root2)
        {

            if (root1 == null)
                return root2;
            if (root2 == null)
                return root1;
            root1.val += root2.val;
            root1.left = MergeTrees2(root1.left, root2.left);
            root1.right = MergeTrees2(root1.right, root2.right);
            return root1;

        }

    }
}
