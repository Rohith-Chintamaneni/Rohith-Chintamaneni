using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Trees;

namespace DataStructures.BinarySearch
{
    class SubtreeofAnotherTree
    {

        // If root node does not match then we traverse root.left check again 
        // Similarily we traverse root.right and check again.
        // Even if left or right does not match we return false.
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null) return false;
            if (isSame(s, t)) return true;
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        private Boolean isSame(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            if (s == null || t == null) return false;

            if (s.val != t.val) return false;

            return isSame(s.left, t.left) && isSame(s.right, t.right);
        }
    }
}
